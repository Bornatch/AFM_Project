import { Injectable, Inject } from '@angular/core';
import { Observable, of, BehaviorSubject } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { tap } from 'rxjs/operators/tap';
import { AppUserAuth } from './app-user-auth';
import { AppUser } from './app-user';
import { getBaseUrl } from 'src/main';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class SecurityService {

  securityObject: AppUserAuth = new AppUserAuth();
  messageSecurity: BehaviorSubject<AppUserAuth> = new BehaviorSubject(this.securityObject);
  apiUrl: string =   'api/security/'

  constructor(private http: HttpClient) { }

  login(entity: AppUser):
    Observable<AppUserAuth> {
    this.resetSecurityObject();
    return this.http.post<AppUserAuth>(
      this.apiUrl + "login",
      entity, httpOptions).pipe(
      tap(resp => {
        // Use object assign to update the 
        //         current object
        Object.assign(this.securityObject, resp);  
        // Store into local storage
        localStorage.setItem("bearerToken", 
            this.securityObject.bearerToken);
      }));
  }

  logout(): void {
    this.resetSecurityObject();
  }

  resetSecurityObject(): void {
    this.securityObject.webUserName = "";
    this.securityObject.bearerToken = "";
    this.securityObject.isAuthenticated = false;
    this.securityObject.isAdmin = false;
    localStorage.removeItem("bearerToken");
  }
}
