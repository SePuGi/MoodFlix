import GeneratedMovie from "./GeneratedMovie.tsx";
import {useParams} from "react-router-dom";
import GeneratedRandomMovie from "./GeneratedRandomMovie.tsx";

function GeneratedMovieWrapper() {
  const {haveEmotions} = useParams<{ haveEmotions: string }>();
  const haveEmotionsBool = haveEmotions === 'true';
  console.log(haveEmotionsBool);

  if (!haveEmotionsBool) {
    return <GeneratedRandomMovie/>
  }

  return <GeneratedMovie/>
}

export default GeneratedMovieWrapper;