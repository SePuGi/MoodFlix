// src/pages/Register.tsx
import React, {useState} from 'react';
import {
  Box,
  Button,
  CircularProgress,
  Container,
  MenuItem,
  TextField,
  Typography,
  Alert,
} from '@mui/material';


// A list of country codes
const countries = [
  {code: 'US', name: 'United States'},
  {code: 'CA', name: 'Canada'},
  {code: 'GB', name: 'United Kingdom'},
  {code: 'AU', name: 'Australia'},
  {code: 'IN', name: 'India'},
  // Add more countries as needed
];

  /**************
  * TODO
  ** - implement the Register
  ** - segregate different compoonents(form)
  ** - create hook for the validate function
  * */
function Register() {
  const [formData, setFormData] = useState({
    userName: '',
    email: '',
    password: '',
    birthDate: '',
    countryCode: '',
  });

  const [errors, setErrors] = useState<{ [key: string]: string }>({});
  const [loading, setLoading] = useState(false);

  const validateForm = () => {
    const newErrors: { [key: string]: string } = {};
    if (!formData.userName) newErrors.userName = 'User name is required.';
    if (!formData.email || !/\S+@\S+\.\S+/.test(formData.email)) newErrors.email = 'Invalid email address.';
    if (!formData.password || !/^(?=.*\d).{8,}$/.test(formData.password)) {
      newErrors.password = 'Password must be at least 8 characters long and include numbers.';
    }
    if (!formData.birthDate) newErrors.birthDate = 'Birth date is required.';
    if (!formData.countryCode) newErrors.countryCode = 'Please select a country.';
    return newErrors;
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const {name, value} = e.target;
    setFormData({...formData, [name]: value});
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    const validationErrors = validateForm();
    if (Object.keys(validationErrors).length > 0) {
      setErrors(validationErrors);
      return;
    }
    setErrors({});
    setLoading(true);

    // Simulating server request
    setTimeout(() => {
      setLoading(false);
      alert('Registration successful!');
    }, 2000);
  };

  return (
    <Container
      maxWidth="sm"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: '100vh',
      }}
    >
      <Typography variant="h1" sx={{fontSize: '1.5rem', marginBottom: 3}}>
        Register
      </Typography>
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
        {Object.keys(errors).length > 0 && (
          <Alert severity="error" sx={{marginBottom: 2}}>
            Please correct the errors below.
          </Alert>
        )}

        <TextField
          label="User Name"
          name="userName"
          fullWidth
          margin="normal"
          value={formData.userName}
          onChange={handleChange}
          error={!!errors.userName}
          helperText={errors.userName}
        />
        <TextField
          label="Email"
          name="email"
          type="email"
          fullWidth
          margin="normal"
          value={formData.email}
          onChange={handleChange}
          error={!!errors.email}
          helperText={errors.email}
        />
        <TextField
          label="Password"
          name="password"
          type="password"
          fullWidth
          margin="normal"
          value={formData.password}
          onChange={handleChange}
          error={!!errors.password}
          helperText={errors.password}
        />
        <TextField
          label="Birth Date"
          name="birthDate"
          type="date"
          fullWidth
          margin="normal"
          InputLabelProps={{shrink: true}}
          value={formData.birthDate}
          onChange={handleChange}
          error={!!errors.birthDate}
          helperText={errors.birthDate}

        />
        <TextField
          select
          label="Country"
          name="countryCode"
          fullWidth
          margin="normal"
          value={formData.countryCode}
          onChange={handleChange}
          error={!!errors.countryCode}
          helperText={errors.countryCode}
        >
          {countries.map((country) => (
            <MenuItem key={country.code} value={country.code}>
              {country.name}
            </MenuItem>
          ))}
        </TextField>
        <Button
          type="submit"
          fullWidth
          variant="contained"
          color="secondary" // changed from primary to secondary
          disabled={loading}
          sx={{marginTop: 2}}
        >
          {loading ? <CircularProgress size={24} sx={{color: 'white'}}/> : 'Register'}
        </Button>
      </Box>
    </Container>
  );
}

export default Register;
