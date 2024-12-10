import React, {useState} from 'react';
import {
  CircularProgress,
  Container,
} from '@mui/material';
import RegisterForm from "../components/Register/RegisterForm.tsx";
import {useFetchCountriesQuery} from "../features/api/preferencesApi.ts";
import {validateForm} from "../utils/validateForm.ts";
import {UserRegisterForm} from "../types/formdata.ts";
import {useRegisterUserMutation} from "../features/api/authApi.ts";
import {useNavigate} from "react-router-dom";
import {MIN_HEIGHT_CONTAINER} from "../constants/constants.ts";

function Register() {
  const [formData, setFormData] = useState<UserRegisterForm>({
    userName: '',
    email: '',
    password: '',
    birthDate: '',
    countryId: '',
  });
  const [errors, setErrors] = useState<{ [key: string]: string }>({});
  const [registerUser, {isLoading: loadingFormSubmit}] = useRegisterUserMutation();
  const {data: countriesData, isLoading: loadingCountries} = useFetchCountriesQuery();
  const navigate = useNavigate();

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const {name, value} = e.target;
    setFormData({...formData, [name]: value});
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    const validationErrors = validateForm(formData);
    if (Object.keys(validationErrors).length > 0) {
      setErrors(validationErrors);
      return;
    }
    setErrors({});

    try {
      await registerUser(formData).unwrap();
      alert('Registration successful!');
      navigate('/login');
    } catch (error) {
      console.error('Error submitting responses:', error);
    }
  };

  return (
    <Container
      maxWidth="sm"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: MIN_HEIGHT_CONTAINER,
      }}
    >
      {loadingCountries ?
        <CircularProgress size={24} sx={{color: 'white'}}/>
        :
        <RegisterForm formData={formData} handleChange={handleChange} countries={countriesData} errors={errors}
                      handleSubmit={handleSubmit} loading={loadingFormSubmit}/>
      }
    </Container>
  );
}

export default Register;
