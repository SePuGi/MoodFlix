// src/features/emotions/emotionsSlice.ts
import {createSlice, PayloadAction} from '@reduxjs/toolkit';
import {EmotionsResponse} from "../../types/emotions.ts";

const initialState: EmotionsResponse = {
  emotions: [],
  description: '',
}

const emotionsSlice = createSlice({
  name: 'emotions',
  initialState,
  reducers: {
    setEmotions: (_, action: PayloadAction<EmotionsResponse>) => action.payload
  },
});

export const {setEmotions} = emotionsSlice.actions;
export default emotionsSlice.reducer;
