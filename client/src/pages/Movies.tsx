import {Container, Typography} from '@mui/material';
import OptionCard from '../components/OptionCard';
import {FaRandom, FaFilm, FaSmile} from 'react-icons/fa';
import {useNavigate} from "react-router-dom";
import {useSelector} from "react-redux";
import {RootState} from "../app/store.ts";

function Movies() {
  const navigate = useNavigate();
  const emotions = useSelector((state: RootState) => state.emotions.emotions);

  const handleRandomMovie = () => {
    navigate('/movies/movieSelected');
  };

  const handleFiveRandomMovies = () => {
    alert('Here are 5 random movies to choose from!');
  };

  const handleMoodMovies = () => {
    if (emotions.length === 0) {
      navigate('/questionnaire');
    } else {
      navigate('/results');
    }
  }

  return (
    <Container
      maxWidth="sm"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
      }}
    >
      <Typography
        variant="h1"
        sx={{fontWeight: 600, margin: '2rem 0'}}
      >
        Explore Your Movie Options
      </Typography>

      <OptionCard
        title="Surprise Me with a Movie!"
        description="Feeling adventurous? Let us surprise you with a random movie recommendation!"
        buttonText="Surprise Me"
        onClick={handleRandomMovie}
        icon={<FaRandom size={32} color="#4CAF50"/>}
      />

      <OptionCard
        title="Pick Your Favorite from 5 Choices!"
        description="Not sure what to watch? Choose your favorite from five handpicked movies."
        buttonText="Show Me 5 Movies"
        onClick={handleFiveRandomMovies}
        icon={<FaFilm size={32} color="#FF9800"/>}
      />

      <OptionCard
        title="Discover Movies Based on Your Feelings!"
        description="Take a fun quiz to match your mood with the perfect movie."
        buttonText="Find Movies by Mood"
        onClick={handleMoodMovies}
        icon={<FaSmile size={32} color="#3F51B5"/>}
      />
    </Container>
  );
}

export default Movies;
