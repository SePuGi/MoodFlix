import {createApi, fetchBaseQuery} from '@reduxjs/toolkit/query/react';
import {EmotionsResponse} from "../../types/emotions.ts";
import {Questionnaire, SubmitResponseItem} from "../../types/questionnaire.ts";

export const questionnaireApi = createApi({
  reducerPath: 'questionnaireApi',
  baseQuery: fetchBaseQuery({baseUrl: 'https://localhost:7116/api'}), // Adjust base URL as needed
  endpoints: (builder) => ({
    fetchQuestions: builder.query<Questionnaire, void>({
      query: () => '/questionary', // API endpoint for fetching questions
    }),
    submitResponses: builder.mutation<EmotionsResponse, SubmitResponseItem[]>({
      query: (body) => ({
        url: 'questionary',
        method: 'POST',
        body,
      })
    })
  }),
});

export const {useSubmitResponsesMutation, useFetchQuestionsQuery} = questionnaireApi;
