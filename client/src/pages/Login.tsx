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
import {MIN_HEIGHT_CONTAINER, MOBILEBAR_HEIGHT} from "../constants/constants.ts";
import {useNavigate} from "react-router-dom";
import {useLoginUserMutation} from "../features/api/authApi.ts";
import {setToken} from "../features/auth/authSlice.ts";
import {useDispatch} from "react-redux";

// TODO LOGIN LOGICA
function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState<string | null>(null);

  const navigate = useNavigate();
  const [loginUser, {isLoading}] = useLoginUserMutation();
  const dispatch = useDispatch();


  const handleSubmit = async (event: React.FormEvent) => {
    event.preventDefault();
    setError(null);

    if (!email || !password) {
      setError('Please fill in all fields');
      return;
    }

    try {
      const {token} = await loginUser({email, password}).unwrap();
      dispatch(setToken(token));
    } catch (error) {
      console.error('Error submitting responses:', error);
    } finally {
      navigate('/');
    }
  };

  return (
    <Container
      maxWidth="xs"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: MIN_HEIGHT_CONTAINER
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
          disabled={isLoading}
          sx={{marginTop: 2}}
        >
          {isLoading ? <CircularProgress size={24} sx={{color: 'white'}}/> : 'Login'}
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
          <Link underline="hover"
                sx={{cursor: 'pointer'}}
                onClick={() => navigate("/register")}>
            Register
          </Link>
        </Typography>
      </Box>
    </Container>
  );
}

export default Login;