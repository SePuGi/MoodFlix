import {configureStore} from '@reduxjs/toolkit';
import {questionnaireApi} from '../features/api/questionnaireApi';
import emotionsReducer from '../features/emotions/emotionsSlice.ts';
import authReducer from '../features/auth/authSlice.ts';
import userReducer from '../features/user/userSlice.ts';
import userPreferencesReducer from '../features/user/userPreferencesSlice.ts'
import {preferencesApi} from "../features/api/preferencesApi.ts";
import {authApi} from "../features/api/authApi.ts";
import {authMiddleware} from "../middleware/authMiddleware.ts";
import {moviesApi} from "../features/api/moviesApi.ts";

export const store = configureStore({
  reducer: {
    [questionnaireApi.reducerPath]: questionnaireApi.reducer,
    [preferencesApi.reducerPath]: preferencesApi.reducer,
    [authApi.reducerPath]: authApi.reducer,
    [moviesApi.reducerPath]: moviesApi.reducer,
    emotions: emotionsReducer,
    auth: authReducer,
    user: userReducer,
    userPreferences: userPreferencesReducer,
  },
  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware().concat(
      questionnaireApi.middleware,
      preferencesApi.middleware,
      authApi.middleware,
      moviesApi.middleware,
      authMiddleware
    ),
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
