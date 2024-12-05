import {Box, Button, Card, CardMedia, Typography, Chip, Grid} from '@mui/material';
import {MovieAPI} from "../types/movies.ts";
import {useSelector} from "react-redux";
import {RootState} from "../app/store.ts";

type MovieCardProps = {
    movie: MovieAPI;
    onWatch: (link: string) => void;
    onTryAgain: () => void;
};

function MovieCard({movie, onWatch, onTryAgain}: MovieCardProps) {
    const primaryPoster = movie.imageSet.verticalPoster.w480; // Use vertical poster+
    const userPlatforms = useSelector((state: RootState) => state.userPreferences.platforms)
        .map(platform => platform.platformName);
    const streamingOptionsFiltered = movie.streamingOptions.serviceOptions.filter(option => (
        userPlatforms.includes(option.serviceName)
    ));

    return (
        <Card
            sx={{
                display: 'flex',
                flexDirection: 'column',
                alignItems: 'center',
                padding: 3,
                backgroundColor: 'background.paper',
                boxShadow: 3,
                maxWidth: 600,
                margin: '0 auto',
            }}
        >
            {/* Movie Poster */}
            <CardMedia
                component="img"
                image={primaryPoster}
                alt={movie.title}
                sx={{
                    width: '100%',
                    maxWidth: 300,
                    borderRadius: 2,
                    marginBottom: 3,
                }}
            />

            {/* Movie Details */}
            <Typography variant="h1" sx={{fontSize: '1.5rem', fontWeight: 600, marginBottom: 1}}>
                {movie.title}
            </Typography>
            <Typography variant="body1" sx={{marginBottom: 2, color: 'text.secondary'}}>
                {movie.overview}
            </Typography>
            <Box sx={{display: 'flex', gap: 1, flexWrap: 'wrap', marginBottom: 2}}>
                {movie.genres.map((genre) => (
                    <Chip key={genre} label={genre} sx={{backgroundColor: 'secondary.main', color: 'white'}}/>
                ))}
            </Box>
            <Typography variant="body2" sx={{marginBottom: 2, fontStyle: 'italic', color: 'text.secondary'}}>
                Directed by: {movie.directors.join(', ')}
            </Typography>
            <Typography variant="body2" sx={{marginBottom: 3, color: 'text.secondary'}}>
                Runtime: {movie.runtime} minutes
            </Typography>

            {/* Streaming Options */}
            <Box sx={{width: '100%', marginBottom: 3}}>
                <Typography variant="h2" sx={{fontSize: '1.25rem', marginBottom: 1}}>
                    Streaming Options:
                </Typography>
                <Grid container spacing={2}>
                    {streamingOptionsFiltered.map((option) => (
                        <Grid item xs={6} key={option.serviceName}>
                            <Box
                                component="a"
                                href={option.link}
                                target="_blank"
                                rel="noopener noreferrer"
                                sx={{
                                    display: 'flex',
                                    alignItems: 'center',
                                    justifyContent: 'space-around',
                                    textDecoration: 'none',
                                    textTransform: 'capitalize',
                                    backgroundColor: 'background.default',
                                    borderRadius: 2,
                                    padding: 2,
                                    boxShadow: 1,
                                    '&:hover': {
                                        boxShadow: "0 1px 4px rgba(255, 255, 255, 0.1)",
                                    },
                                }}
                            >
                                <img
                                    src={option.imageSet.darkThemeImage}
                                    alt={option.serviceName}
                                    style={{height: 40, marginRight: 10}}
                                />
                            </Box>
                            <Typography
                                display={"block"}
                                mt={1}
                                variant="caption"
                                color="text.secondary"
                                textAlign={"center"}
                                textTransform={"capitalize"}>
                                {option.accesType}
                            </Typography>
                        </Grid>
                    ))}
                </Grid>
            </Box>

            {/* Action Buttons */}
            <Box sx={{display: 'flex', gap: 2}}>
                <Button variant="contained" color="primary"
                        onClick={() => onWatch(movie.streamingOptions.serviceOptions[0]?.link)}>
                    Watch
                </Button>
                <Button variant="outlined" color="secondary" onClick={onTryAgain}>
                    Try Again
                </Button>
            </Box>
        </Card>
    );
}

export default MovieCard;
