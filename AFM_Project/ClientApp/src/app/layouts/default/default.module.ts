import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { AdminDashboardComponent } from 'src/app/modules/admin-dashboard/admin-dashboard.component';
import { RouterModule } from '@angular/router';
import { PagesComponent } from '../../modules/pages/pages.component';
import { SharedModule } from '../../shared/shared.module';
import { MatSidenavModule } from '@angular/material'
 


@NgModule({
  declarations: [
    DefaultComponent,
    AdminDashboardComponent,
    PagesComponent  
  ],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    MatSidenavModule
  ]
})
export class DefaultModule { }
