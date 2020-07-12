import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { FooterComponent } from './components/footer/footer.component';
import { LoginComponent } from './components/security/login.component'
import { MatAutocompleteModule, MatInputModule , MatDividerModule, MatToolbarModule, MatIconModule, MatButtonModule, MatMenuModule, MatListModule } from '@angular/material';
import { FlexibleConnectedPositionStrategy } from '@angular/cdk/overlay';
import { FlexLayoutModule } from '@angular/flex-layout'
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HighchartsChartModule } from 'highcharts-angular';
import { QuotesHistoriesComponent } from './widgets/quotes-histories/quotes-histories.component';



@NgModule({
  declarations: [
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    LoginComponent,
    QuotesHistoriesComponent,

  ],
  imports: [
    CommonModule,
    MatDividerModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    FlexLayoutModule,
    MatMenuModule,
    MatListModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    MatAutocompleteModule,
    MatInputModule,
    HighchartsChartModule
  ],
  exports: [
    // shared
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    //security
    LoginComponent,
    // widgets
    QuotesHistoriesComponent
  ]
})
export class SharedModule { }
