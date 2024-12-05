import {createSlice, PayloadAction} from "@reduxjs/toolkit";

export type User = {
  userId: number | null;
  userName: string;
  email: string;
  birthDate: string;
  countryId: number | null;
}

const initialState: User = {
  userId: null,
  userName: '',
  email: '',
  birthDate: '',
  countryId: null,
}

const userSlice = createSlice({
  name: 'user',
  initialState,
  reducers: {
    setUser: (_, action: PayloadAction<User>) => action.payload,
    clearUser: () => initialState
  }
})

export const {setUser, clearUser} = userSlice.actions;
export default userSlice.reducer;