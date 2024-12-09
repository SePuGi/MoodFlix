import {useGenerateMovieWithEmotionsMutation} from "../features/api/moviesApi.ts";
import {useSelector} from "react-redux";
import {RootState} from "../app/store.ts";
import MovieList from "../components/MovieList.tsx";

function GeneratedMovie() {
  const emotions = useSelector((state: RootState) => state.emotions.emotions);
  const [generateMovieWithEmotions, {isLoading, isError}] = useGenerateMovieWithEmotionsMutation();

  const fetchMoviesOnEmotions = async (recentMoviesTitles: string[]) => {
    const ids = emotions.map(emotion => emotion.id);
    const result = await generateMovieWithEmotions({
      body: {emotionId: ids, movieSuggested: recentMoviesTitles},
      movieCount: 1
    }).unwrap();
    return result;
  }

  return <MovieList isLoading={isLoading} isError={isError} fetchMovies={fetchMoviesOnEmotions}/>;
}

export default GeneratedMovie;
