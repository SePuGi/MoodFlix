import {createApi, fetchBaseQuery} from '@reduxjs/toolkit/query/react';
import {RootState} from "../../app/store.ts";
import {MovieAPI} from "../../types/movies.ts";

type GenerateMovieOnEmotions = {
  emotionId: number[];
  movieSuggested: string[];
}

export const moviesApi = createApi({
  reducerPath: 'moviesApi',
  baseQuery: fetchBaseQuery({
    baseUrl: 'https://localhost:7116/api/Movie',
    prepareHeaders: (headers, {getState}) => {
      const token = (getState() as RootState).auth.token;
      if (token) {
        headers.set('Authorization', `Bearer ${token}`);
      }
      return headers;
    },
  }),
  endpoints: (builder) => ({
    generateMovieWithEmotions: builder.mutation<MovieAPI[], { body: GenerateMovieOnEmotions, movieCount: number }>({
      query: ({body, movieCount}) => ({
        url: `/GetMoviesWithEmotions/${movieCount}`,
        method: 'POST',
        body,
      })
    }),
    generateRandomMovie: builder.mutation<MovieAPI[], { body: string[], movieCount: number }>({
      query: ({body, movieCount}) => ({
        url: `/GetMoviesWithPreferences/${movieCount}`,
        method: 'POST',
        body,
      })
    })
  }),
});

export const {useGenerateRandomMovieMutation, useGenerateMovieWithEmotionsMutation} = moviesApi;