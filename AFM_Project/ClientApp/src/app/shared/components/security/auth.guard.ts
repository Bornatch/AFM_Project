import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { SecurityService } from './security.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  
canActivate(next: ActivatedRouteSnapshot,
  state: RouterStateSnapshot): 
Observable<boolean> | Promise<boolean>
| boolean {
// Get property name to check
let claimName: string =
next.data["claimName"];
return this.securityService
.securityObject.isAuthenticated &&
this.securityService
.securityObject[claimName];
}

  constructor
  (private securityService: SecurityService) { }
  
}
