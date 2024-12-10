import {Box, CircularProgress, Typography} from '@mui/material';
import {MovieAPI} from '../types/movies.ts';
import MovieCard from './MovieCard.tsx';
import MovieButtons from './MovieButtons.tsx';
import {useEffect, useState} from "react";
import {RootState} from "../app/store.ts";
import {useDispatch, useSelector} from "react-redux";
import {setRecentMovies} from "../features/movie/recentMoviesSlice.ts";
import {MIN_HEIGHT_CONTAINER, MOBILEBAR_HEIGHT} from "../constants/constants.ts";

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

  if (isError) {
    return (
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          justifyContent: 'center',
          height: '100vh',
          backgroundColor: 'background.default',
        }}
      >
        <Typography variant="h2" sx={{textAlign: 'center', marginTop: '2rem'}}>
          Error loading movies. Please try again.
        </Typography>
        <MovieButtons refresh={refreshMovies}/>
      </Box>
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
    <Box
      sx={{padding: 3, backgroundColor: 'background.default', minHeight: MIN_HEIGHT_CONTAINER, mb: MOBILEBAR_HEIGHT}}>
      {movies.map((movie) =>
        <MovieCard key={movie.id} movie={movie}/>
      )}
      <MovieButtons refresh={refreshMovies}/>
    </Box>
  )
}

export default MovieList;