import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { FooterComponent } from './components/footer/footer.component';
import { LoginComponent } from './components/security/login.component'
import { MatAutocompleteModule, MatInputModule, 
  MatDividerModule, MatToolbarModule, MatIconModule, 
  MatButtonModule, MatMenuModule, MatListModule,
  MatCheckboxModule, MatRadioModule, MatTableModule,
  MatGridListModule,} from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout'
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HighchartsChartModule } from 'highcharts-angular';
//widget
import { QuotesHistoriesComponent } from './widgets/quotes-histories/quotes-histories.component';
import { PerformencesComponent } from './widgets/performences/performences.component';
import { PerformencesIndexComponent } from './widgets/performences-index/performences-index.component';
import { StatisticComponent } from './widgets/statistic/statistic.component';

@NgModule({
  declarations: [
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    LoginComponent,
    QuotesHistoriesComponent,
    PerformencesComponent,
    PerformencesIndexComponent,
    StatisticComponent
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
    MatCheckboxModule,
    MatRadioModule,
    MatTableModule,
    MatGridListModule,
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
    QuotesHistoriesComponent,
    PerformencesComponent,
    PerformencesIndexComponent,
    StatisticComponent
  ]
})
export class SharedModule { }
