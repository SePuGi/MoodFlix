// src/features/emotions/emotionsSlice.ts
import {createSlice, PayloadAction} from '@reduxjs/toolkit';
import {Emotion, EmotionsState} from "../../types/emotions.ts";

const initialState: EmotionsState = {
  emotions: [],
};

const emotionsSlice = createSlice({
  name: 'emotions',
  initialState,
  reducers: {
    setEmotions: (state, action: PayloadAction<Emotion[]>) => {
      state.emotions = action.payload;
    },
  },
});

export const {setEmotions} = emotionsSlice.actions;
export default emotionsSlice.reducer;
