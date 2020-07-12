import { AppUserAuth } from "./app-user-auth";

export const LOGIN_MOCKS: AppUserAuth[] = [
  {
    userName: "Admin",
    bearerToken: "sd9f923k3kdmcjkhd",
    isAuthenticated: true,
    isAdmin: true,
  },
  {
    userName: "User",
    bearerToken: "sd9f923k3kdmcjkhd",
    isAuthenticated: true,
    isAdmin: false,
  },
];

