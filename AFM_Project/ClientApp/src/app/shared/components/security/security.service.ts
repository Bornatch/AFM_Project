import { Injectable } from '@angular/core';
import { Observable, of, BehaviorSubject } from 'rxjs';
import { AppUserAuth } from './app-user-auth';
import { AppUser } from './app-user';
import { LOGIN_MOCKS } from './login-mocks';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {

  securityObject: AppUserAuth = new AppUserAuth();
  messageSecurity: BehaviorSubject<AppUserAuth> = new BehaviorSubject(this.securityObject);

  constructor() { }

  login(entity: AppUser):
    Observable<AppUserAuth> {
    this.resetSecurityObject();
    Object.assign(this.securityObject,
      LOGIN_MOCKS.find(
        user => user.userName.toLowerCase() ===
          entity.userName.toLowerCase()));
    if (this.securityObject.userName !== "") {
      localStorage.setItem("bearerToken",
        this.securityObject.bearerToken);
    }
    return of<AppUserAuth>(this.securityObject);
  }

  logout(): void {
    this.resetSecurityObject();
  }
  
  resetSecurityObject(): void {
    this.securityObject.userName = "";
    this.securityObject.bearerToken = "";
    this.securityObject.isAuthenticated = false;
    this.securityObject.isAdmin = false;
    localStorage.removeItem("bearerToken");
  }
}
