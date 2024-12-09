import {useDispatch, useSelector} from 'react-redux';
import {useNavigate} from 'react-router-dom';
import {RootState} from '../app/store';
import {Typography, Box, Button, Card, CardContent, Grid} from '@mui/material';
import {setEmotions} from "../features/emotions/emotionsSlice.ts";

function Results() {
  const emotions = useSelector((state: RootState) => state.emotions);
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const handleRestart = () => {
    dispatch(setEmotions({emotions: [], description: ''}));
    navigate('/questionnaire');
  };

  const handleGetMovie = () => {
    navigate(`/movies/generateMovie/emotions/${true}`);
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: '100vh',
        backgroundColor: 'background.default',
        color: 'text.primary',
        padding: 3,
      }}
    >
      <Typography variant="h1" sx={{marginBottom: 3}}>
        Your Emotional Results
      </Typography>

      <Grid container spacing={2} justifyContent="center" sx={{maxWidth: 600, marginBottom: 4}}>
        {emotions.emotions.map((emotion, index) => (
          <Grid item xs={12} sm={6} key={emotion.name}>
            <Card
              sx={{
                backgroundColor: 'background.paper',
                boxShadow: 3,
                padding: 2,
                textAlign: 'center',
                border: index === 0 ? '2px solid #4CAF50' : undefined, // Highlight top emotion
              }}
            >
              <CardContent>
                <Typography
                  variant="h2"
                  sx={{
                    fontSize: '1.25rem',
                    fontWeight: index === 0 ? 'bold' : 'normal',
                    color: index === 0 ? 'primary.main' : 'text.primary',
                  }}
                >
                  {index + 1}. {emotion.name}
                </Typography>
                <Typography
                  variant="h3"
                  sx={{
                    fontSize: '1rem',
                    color: 'text.secondary',
                  }}
                >
                  Score: {emotion.score}
                </Typography>
              </CardContent>
            </Card>
          </Grid>
        ))}
        <Typography
          variant="body1"
          sx={{
            color: 'text.secondary',
            marginTop: 2,
          }}
        >
          {emotions.description}
        </Typography>
      </Grid>

      <Box sx={{display: 'flex', gap: 2}}>
        <Button
          variant="contained"
          color="secondary"
          onClick={handleRestart}
          sx={{textTransform: 'uppercase'}}
        >
          Restart Questionnaire
        </Button>
        <Button
          variant="contained"
          color="primary"
          onClick={handleGetMovie}
          sx={{textTransform: 'uppercase'}}
        >
          Get Movie
        </Button>
      </Box>
    </Box>
  );
}

export default Results;
