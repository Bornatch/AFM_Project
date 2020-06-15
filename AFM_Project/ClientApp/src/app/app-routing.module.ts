import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DefaultComponent } from './layouts/default/default.component';
import { AdminDashboardComponent } from './modules/admin-dashboard/admin-dashboard.component';
import { PagesComponent } from './modules/pages/pages.component';


const routes: Routes = [{
  path: '',
  component: DefaultComponent,
  children: [{
    path: '',
    component: AdminDashboardComponent
  }, {
    path: 'pages',
    component: PagesComponent
  }]
}];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes),
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
