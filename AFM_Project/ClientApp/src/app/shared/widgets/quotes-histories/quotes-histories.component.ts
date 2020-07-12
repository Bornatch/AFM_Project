import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as Highcharts from 'highcharts/highstock';
import StockModule from 'highcharts/modules/stock';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith, distinct, switchMap } from 'rxjs/operators';
import { ApiService } from '../../../api.service';

@Component({
  selector: 'app-widget-quotes-histories',
  templateUrl: './quotes-histories.component.html',
  styleUrls: ['./quotes-histories.component.scss']
})

export class QuotesHistoriesComponent implements  OnChanges {

  //Chart info
  Highcharts = Highcharts;
  chartConstructor = 'stockChart';
  chartOptions: {};
  selectedStock: string = 'AAPL';
  
 //charts'data 
  quotes: IQuotes[];
  datas = new Array<any>();
  myControl = new FormControl();
  filteredOptions: Observable<string[]>;

  constructor(private apiService: ApiService) {
  }
  ngOnChanges(changes: SimpleChanges) {
    //Selector    
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      switchMap(value => { return  this._filter(value || '') })
    );      
     // build chart
     this.setChart();    
  }  

  ngOnInit() {
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      switchMap(value => { return  this._filter(value || '') })
    );      
     // build chart
     this.setChart();    
  }  
  
  private _filter(value: string): Observable<any[]> {
    const filterValue = value.toLowerCase();

    return this.apiService.getQuotesHistoriesSecurities()
      .pipe(
        map(response => response.filter(option => {
          return option.toLowerCase().indexOf(filterValue) === 0
        })
        )
      )
  }

  onSelectedStock(option:string){
    this.selectedStock = option;
    this.setChart();
  }

  private setChart(){
    this.apiService.getQuotesHistories(this.selectedStock).subscribe(result => {
      this.quotes = result;
      
      //Chart
      this.setData();
      this.chartOptions = {
        rangeSelector: {
          selected: 1
        },
        title: {
          text: this.quotes[1].security + ' Stock Price'
        },
        series: [{
          name: this.quotes[1].security,
          data: this.datas,
          tooltip: {
            valueDecimals: 2
          }
        }]
      };   
    }, error => console.error(error));
  }

  private setData() {
    //reset datas
    this.datas = [];
    for (let i = 0; i < this.quotes.length; i++) {
      //change string date from MSSQLDB to Timestamp
      let date = new Date(this.quotes[i].quoteDateTime);
      let timestamp = date.getTime();

      this.datas.push([
        timestamp,
        this.quotes[i].lastTrade]
      );
    };
  }
}

export interface IQuotes {
  security: string;
  //  ask: number;
  //  bid: number;
  lastTrade: number;
  quoteDateTime: string;
}
