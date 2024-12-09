import {useGenerateRandomMovieMutation} from "../features/api/moviesApi.ts";
import MovieList from "../components/MovieList.tsx";

function GeneratedRandomMovie() {
  const [generateRandomMovie, {isLoading, isError}] = useGenerateRandomMovieMutation();

  const fetchRandomMovies = async (recentMoviesTitles: string[]) => {
    const result = await generateRandomMovie({
      body: recentMoviesTitles,
      movieCount: 1
    }).unwrap();
    return result;
  }

  return <MovieList isLoading={isLoading} isError={isError} fetchMovies={fetchRandomMovies}/>;
}

export default GeneratedRandomMovie;
