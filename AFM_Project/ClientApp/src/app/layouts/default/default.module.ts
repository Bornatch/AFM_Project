import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { AdminDashboardComponent } from 'src/app/modules/admin-dashboard/admin-dashboard.component';
import { RouterModule } from '@angular/router';
import { PagesComponent } from '../../modules/pages/pages.component';
import { SharedModule } from '../../shared/shared.module';
import { MatSidenavModule, MatDividerModule} from '@angular/material'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { StatisticsPagesComponent } from 'src/app/modules/statistics-pages/statistics-pages.component';
 
@NgModule({
  declarations: [
    DefaultComponent,
    AdminDashboardComponent,
    PagesComponent,  
    StatisticsPagesComponent  
  ],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    MatSidenavModule,
    MatDividerModule,
    FormsModule
  ]
})
export class DefaultModule { }
