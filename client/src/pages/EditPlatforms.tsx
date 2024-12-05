/*import React, {useState} from 'react';
import {Box, Typography, Grid, Button} from '@mui/material';
import platformsData, {Platform} from '../data/platformData.ts';
import PlatformCard from '../components/PlatformCard';
import {useNavigate} from "react-router-dom";

function EditPlatforms() {
  const [selectedPlatforms, setSelectedPlatforms] = useState<string[]>([]);
  const navigate = useNavigate();

  const handleTogglePlatform = (id: string) => {
    setSelectedPlatforms((prev) =>
      prev.includes(id) ? prev.filter((platformId) => platformId !== id) : [...prev, id]
    );
  };

  const handleSave = () => {
    alert(`Selected platforms: ${selectedPlatforms.join(', ')}`);
    navigate('/profile');
    // TODO: Replace with API call to save selected platforms
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
      <Typography variant="h1" sx={{fontSize: '1.5rem', marginBottom: 3}}>
        Edit Platforms
      </Typography>

      <Grid container spacing={2} sx={{maxWidth: 600}}>
        {platformsData.map((platform) => (
          <Grid item xs={12} sm={6} key={platform.id}>
            <PlatformCard
              platform={platform}
              isSelected={selectedPlatforms.includes(platform.id)}
              onToggle={handleTogglePlatform}
            />
          </Grid>
        ))}
      </Grid>

      <Button
        variant="contained"
        color="primary"
        onClick={handleSave}
        sx={{marginTop: 3, textTransform: 'uppercase'}}
      >
        Save Changes
      </Button>
    </Box>
  );
}

export default EditPlatforms;*/
