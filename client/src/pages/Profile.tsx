import {useState} from 'react';
import {Box, Button, Typography} from '@mui/material';
import EditableField from '../components/EditableField';
import {useNavigate} from 'react-router-dom';
import {MIN_HEIGHT_CONTAINER} from "../constants/constants.ts";

function Profile() {
  const navigate = useNavigate();

  /*TODO: Replace the hard-coded values with state variables from userSlice*/
  const [email, setEmail] = useState('user@example.com');
  const [password, setPassword] = useState('********');
  const [username, setUsername] = useState('JohnDoe');

  const handleEditPlatforms = () => {
    navigate('/profile/platforms');
  };

  const handleEditGenres = () => {
    alert('Edit genres clicked');
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'center',
        minHeight: MIN_HEIGHT_CONTAINER,
        backgroundColor: 'background.default',
        color: 'text.primary',
        padding: 3,
      }}
    >
      <Typography variant="h1" sx={{fontSize: '1.5rem', marginBottom: 5, textAlign: 'center'}}>
        Profile
      </Typography>

      <EditableField
        label="Email"
        value={email}
        onSave={(newValue) => setEmail(newValue)}
      />
      <EditableField
        label="Password"
        value={password}
        onSave={(newValue) => setPassword(newValue)}
      />
      <EditableField
        label="Username"
        value={username}
        onSave={(newValue) => setUsername(newValue)}
      />

      <Box sx={{display: 'flex', gap: 2, marginTop: 3, justifyContent: 'center'}}>
        <Button
          variant="contained"
          color="secondary"
          onClick={handleEditPlatforms}
          sx={{textTransform: 'uppercase'}}
        >
          Edit Platforms
        </Button>
        <Button
          variant="contained"
          color="primary"
          onClick={handleEditGenres}
          sx={{textTransform: 'uppercase'}}
        >
          Edit Genres
        </Button>
      </Box>
    </Box>
  );
}

export default Profile;
