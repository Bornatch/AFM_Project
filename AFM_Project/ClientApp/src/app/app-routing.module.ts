import { NgModule, Injectable } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { LoginComponent } from './shared/components/security/login.component'
import { DefaultComponent } from './layouts/default/default.component';
import { AdminDashboardComponent } from './modules/admin-dashboard/admin-dashboard.component';
import { PagesComponent } from './modules/pages/pages.component';
import { Observable } from 'rxjs';
import { SecurityService } from './shared/components/security/security.service';
import { StatisticsPagesComponent } from './modules/statistics-pages/statistics-pages.component';

@Injectable()
class AuthGuard implements CanActivate {
  canActivate(next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot):
    Observable<boolean> | Promise<boolean>
    | boolean {
    // Get property name to check
    let claimName: string =
      next.data["claimName"];
    if (this.securityService
      .securityObject.isAuthenticated
      && this.securityService
        .securityObject[claimName]) {
      return true;
    }
    else {
      this.router.navigate(['login'],
        { queryParams: { returnUrl: state.url } });
      return false;
    }
  }

  constructor
    (private securityService: SecurityService, private router : Router) { 
    }
}

const routes: Routes = [{
  path: '',
  component: DefaultComponent,
  children: [{
    path: 'login',
    component: LoginComponent
  },
  {
    path: '',
    component: AdminDashboardComponent,
    canActivate: [AuthGuard],
    data: { claimName: 'isAuthenticated' }
  }, {
    path: 'pages',
    component: PagesComponent,
    canActivate: [AuthGuard],
    data: { claimName: 'isAuthenticated' }
  },  {
    path: 'statistics',
    component: StatisticsPagesComponent,
    canActivate: [AuthGuard],
    data: { claimName: 'isAuthenticated' }
  }],
}]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes),

  ],
  exports: [
    RouterModule
  ],
  providers: [AuthGuard]
})
export class AppRoutingModule { }
