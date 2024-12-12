import {User} from "./user.ts";

export type UserRegisterForm = Pick<User, 'userName' | 'email' | 'birthDate'> &
  {
    password: string,
    countryId: number | '',
  }

