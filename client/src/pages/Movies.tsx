import {Container, Typography} from '@mui/material';
import OptionCard from '../components/OptionCard';
import {FaRandom, FaFilm, FaSmile} from 'react-icons/fa';

function Movies() {
  const handleRandomMovie = () => {
    alert('Surprise! A random movie will be selected for you.');
  };

  const handleFiveRandomMovies = () => {
    alert('Here are 5 random movies to choose from!');
  };

  const handleEmotionalMood = () => {
    alert('Let’s discover movies based on your mood.');
  };

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
        sx={{fontSize: '1.5rem', fontWeight: 600, margin: '2rem 0'}}
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
        onClick={handleEmotionalMood}
        icon={<FaSmile size={32} color="#3F51B5"/>}
      />
    </Container>
  );
}

export default Movies;
