import {useGenerateRandomMovieMutation} from "../features/api/moviesApi.ts";
import {Box, CircularProgress, Typography} from "@mui/material";
import {useEffect, useState} from "react";
import {MovieAPI} from "../types/movies.ts";
import MovieCard from "../components/MovieCard.tsx";

function MovieSelected() {
  const [generateRandomMovie, {isLoading, isError}] = useGenerateRandomMovieMutation();
  const [movies, setMovies] = useState<MovieAPI[]>([]);

  useEffect(() => {
    const fetchMovies = async () => {
      try {
        const response = await generateRandomMovie([]).unwrap();
        setMovies(response);
      } catch (error) {
        console.error('Error fetching movies:', error);
      }
    }

    fetchMovies();
  }, [generateRandomMovie]);

  const handleAgain = async () => {
    try {
      const previousMovies = movies.map(m => m.title);
      const response = await generateRandomMovie(previousMovies).unwrap();
      setMovies(response);
    } catch (error) {
      console.error('Error fetching movies:', error);
    }
  }

  const handleWatch = (link: string) => {
    if (link) {
      window.open(link, '_blank', 'noopener,noreferrer');
    } else {
      alert('No streaming link available.');
    }
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
      {movies.map((movie) => {
        return (
          <MovieCard key={movie.id} movie={movie} onWatch={handleWatch} onTryAgain={handleAgain}/>
        )
      })}
    </Box>
  );
}

export default MovieSelected;