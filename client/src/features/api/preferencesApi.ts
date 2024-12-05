import {createApi, fetchBaseQuery} from '@reduxjs/toolkit/query/react';
import {Country, Genre, Platform} from "../../types/preferences.ts";
import {RootState} from "../../app/store.ts";

export const preferencesApi = createApi({
  reducerPath: 'preferencesApi',
  baseQuery: fetchBaseQuery({
    baseUrl: 'https://localhost:7116/api/Users',
    prepareHeaders: (headers, {getState}) => {
      const token = (getState() as RootState).auth.token;
      if (token) {
        headers.set('Authorization', `Bearer ${token}`);
      }
      return headers;
    },
  }),
  endpoints: (builder) => ({
    fetchGenres: builder.query<Genre[], void>({
      query: () => '/Genres',
    }),
    fetchPlatforms: builder.query<Platform[], string>({
      query: (code) => `/Platforms/${code}`
    }),
    fetchCountries: builder.query<Country[], void>({
      query: () => '/Countries'
    }),
    getUserPreferences: builder.query<{ genres: Genre[], platforms: Platform[] }, void>({
      query: () => '/userPreferences'
    })
  }),
});

export const {
  useFetchGenresQuery,
  useFetchPlatformsQuery,
  useFetchCountriesQuery,
  useGetUserPreferencesQuery
} = preferencesApi;