import {Box, CircularProgress, Typography} from '@mui/material';
import {useGenerateMovieWithEmotionsMutation} from "../features/api/moviesApi.ts";
import {useEffect, useState} from "react";
import {MovieAPI} from "../types/movies.ts";
import {useSelector} from "react-redux";
import {RootState} from "../app/store.ts";
import MovieButtons from "../components/MovieButtons.tsx";
import MovieCard from "../components/MovieCard.tsx";

function GeneratedMovie() {
  const emotions = useSelector((state: RootState) => state.emotions.emotions);
  const [movies, setMovies] = useState<MovieAPI[]>([]);
  const [generateMovieWithEmotions, {isLoading, isError}] = useGenerateMovieWithEmotionsMutation();

  const fetchMovies = async () => {
    const ids = emotions.map(emotion => emotion.id);
    const result = await generateMovieWithEmotions({
      body: {emotionId: ids, movieSuggested: movies.map(m => m.title)},
      movieCount: 1
    }).unwrap();
    setMovies(result);
  }

  useEffect(() => {
    fetchMovies()
  }, []);

  const addToHistory = () => {
    alert('No streaming link available.');
  };

  const handleRefresh = async () => {
    fetchMovies();
  }

  if (isError) {
    return (
      <Typography variant="h2" sx={{textAlign: 'center', marginTop: '2rem'}}>
        Error loading movies. Please try again later.
      </Typography>
    );
  }

  if (isLoading) {
    return (
      <Box
        sx={{
          display: 'flex',
          justifyContent: 'center',
          alignItems: 'center',
          height: '100vh',
          backgroundColor: 'background.default',
        }}
      >
        <CircularProgress color="primary"/>
      </Box>
    );
  }

  return (
    <Box sx={{padding: 3, backgroundColor: 'background.default', minHeight: '100vh'}}>
      {movies.map((movie) => (
        <MovieCard key={movie.id} movie={movie}/>
      ))}
      {/* Action Buttons */}
      <MovieButtons add={addToHistory} refresh={handleRefresh}/>
    </Box>
  );
}

export default GeneratedMovie;
