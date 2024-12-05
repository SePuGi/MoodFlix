/*
import React, { useState } from 'react';
import { Box, Typography, Grid, Button } from '@mui/material';

function EditGenres() {
  const [selectedGenres, setSelectedGenres] = useState<string[]>([]);

  const handleToggleGenre = (id: string) => {
    setSelectedGenres((prev) =>
      prev.includes(id) ? prev.filter((genreId) => genreId !== id) : [...prev, id]
    );
  };

  const handleSave = () => {
    alert(`Selected genres: ${selectedGenres.join(', ')}`);
    // TODO: Replace with API call to save selected genres
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        padding: 3,
        backgroundColor: 'background.default',
        minHeight: '100vh',
      }}
    >
      <Typography variant="h1" sx={{ fontSize: '1.5rem', marginBottom: 3 }}>
        Edit Genres
      </Typography>

      <Grid container spacing={2} sx={{ maxWidth: 600 }}>
        {genresData.map((genre) => (
          <Grid item xs={12} sm={6} key={genre.id}>
            <GenreCard
              genre={genre}
              isSelected={selectedGenres.includes(genre.id)}
              onToggle={handleToggleGenre}
            />
          </Grid>
        ))}
      </Grid>

      <Button
        variant="contained"
        color="primary"
        onClick={handleSave}
        sx={{ marginTop: 3, textTransform: 'uppercase' }}
      >
        Save Changes
      </Button>
    </Box>
  );
}

export default EditGenres;
*/
