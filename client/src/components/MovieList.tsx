import {Box, CircularProgress, Typography} from '@mui/material';
import {MovieAPI} from '../types/movies.ts';
import MovieCard from './MovieCard.tsx';
import MovieButtons from './MovieButtons.tsx';
import {useEffect, useState} from "react";
import {RootState} from "../app/store.ts";
import {useDispatch, useSelector} from "react-redux";
import {setRecentMovies} from "../features/movie/recentMoviesSlice.ts";

interface MovieListProps {
  isLoading: boolean;
  isError: boolean;
  fetchMovies: (recentMovies: string[]) => Promise<MovieAPI[]>;
}

function MovieList({isLoading, isError, fetchMovies}: MovieListProps) {
  const [movies, setMovies] = useState<MovieAPI[]>([]);
  const recentMoviesTitles = useSelector((state: RootState) => state.recentMovies)
    .map(movie => movie.title);
  const dispatch = useDispatch();

  const refreshMovies = () => {
    fetchMovies(recentMoviesTitles).then(result => {
      setMovies(result);
      dispatch(setRecentMovies(result));
    });
  };

  useEffect(() => {
    refreshMovies();
  }, []);

  const addToHistory = () => {
    alert('No streaming link available.');
  };

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
      <MovieButtons add={addToHistory} refresh={refreshMovies}/>
    </Box>
  );
}

export default MovieList;