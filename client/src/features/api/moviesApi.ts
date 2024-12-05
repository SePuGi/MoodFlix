import {createApi, fetchBaseQuery} from '@reduxjs/toolkit/query/react';
import {RootState} from "../../app/store.ts";
import {MovieAPI} from "../../types/movies.ts";
import {EmotionsResponse} from "../../types/emotions.ts";
import {SubmitResponseItem} from "../../types/questionnaire.ts";

export const moviesApi = createApi({
  reducerPath: 'moviesApi',
  baseQuery: fetchBaseQuery({
    baseUrl: 'https://localhost:7116/api/Movie/GetMoviesWithPreferences/1',
    prepareHeaders: (headers, {getState}) => {
      const token = (getState() as RootState).auth.token;
      if (token) {
        headers.set('Authorization', `Bearer ${token}`);
      }
      return headers;
    },
  }),
  endpoints: (builder) => ({
    getRandomMovie: builder.query<MovieAPI[], void>({
      query: () => `/`,
    }),
    generateRandomMovie: builder.mutation<MovieAPI[], string[]>({
      query: (body) => ({
        url: '/',
        method: 'POST',
        body,
      })
    })
  }),
});

export const {useGetRandomMovieQuery, useGenerateRandomMovieMutation} = moviesApi;