// src/pages/Login.tsx
import React, {useState} from 'react';
import {
  Box,
  Button,
  CircularProgress,
  Container,
  TextField,
  Typography,
  Alert,
  Link,
} from '@mui/material';
import {LuClapperboard} from 'react-icons/lu'
import {MOBILEBAR_HEIGHT} from "../constants/constants.ts";
import {useNavigate} from "react-router-dom";

// TODO LOGIN LOGICA
function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const navigate = useNavigate();

  const handleSubmit = (event: React.FormEvent) => {
    event.preventDefault();
    setError(null);
    setLoading(true);

    // Mock server request
    setTimeout(() => {
      setLoading(false);
      if (email !== 'test@example.com' || password !== 'password') {
        setError('Invalid credentials. Please try again.');
      }
    }, 2000);
  };

  return (
    <Container
      maxWidth="xs"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: `calc(100vh - ${MOBILEBAR_HEIGHT}px)`
      }}
    >
      {/* Icon and Title */}
      <Box
        sx={{
          textAlign: 'center',
          marginBottom: 4,
        }}
      >
        <LuClapperboard size={48} color="#4CAF50"/>
        <Typography variant="h1" sx={{marginTop: 1}}>
          Welcome Back
        </Typography>
        <Typography variant="body1" color="text.secondary">
          Sign in to continue your movie journey!
        </Typography>
      </Box>

      {/* TODO separate in other Form component */}
      <Box
        component="form"
        onSubmit={handleSubmit}
        sx={{
          width: '100%',
          backgroundColor: 'background.paper',
          padding: 3,
          borderRadius: 2,
          boxShadow: 3,
        }}
      >
        {error && (
          <Alert severity="error" sx={{marginBottom: 2}}>
            {error}
          </Alert>
        )}
        <TextField
          label="Email"
          type="email"
          fullWidth
          margin="normal"
          required
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <TextField
          label="Password"
          type="password"
          fullWidth
          margin="normal"
          required
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <Button
          type="submit"
          fullWidth
          variant="contained"
          color="primary"
          disabled={loading}
          sx={{marginTop: 2}}
        >
          {loading ? <CircularProgress size={24} sx={{color: 'white'}}/> : 'Login'}
        </Button>
      </Box>

      {/* Register Option */}
      <Box
        sx={{
          textAlign: 'right',
          marginTop: 2,
          width: '100%',
        }}
      >
        <Typography variant="body2" color="text.secondary">
          Not registered yet?{' '}
          <Link underline="hover" onClick={() => navigate("/register")}>
            Register
          </Link>
        </Typography>
      </Box>
    </Container>
  );
}

export default Login;
