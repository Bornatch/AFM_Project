import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as Highcharts from 'highcharts/highstock';
import StockModule from 'highcharts/modules/stock';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { ApiService } from '../../../api.service';

@Component({
  selector: 'app-widget-quotes-histories',
  templateUrl: './quotes-histories.component.html',
  styleUrls: ['./quotes-histories.component.scss']
})

export class QuotesHistoriesComponent implements OnInit {

  //Chart info
  Highcharts = Highcharts;
  chartConstructor = 'stockChart';
  chartOptions: {};
  
 //charts'data 
  quotes: IQuotes[];
  datas = new Array<any>();

  //stockselector
  myControl = new FormControl();
  options: string[] = ['One', 'Two', 'Three'];
  filteredOptions: Observable<string[]>;

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    //Selector
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value))
    );
    // build chart
    this.apiService.getQuotesHistories().subscribe(result => {
      this.quotes = result;
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

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();

    return this.options.filter(option => option.toLowerCase().indexOf(filterValue) === 0);
  }

  setData() {
    for (let i = 0; i < this.quotes.length; i++) {
      //change string date from MSSQLDB to Timestamp
      let date = new Date(this.quotes[i].quoteDateTime);
      let timestamp = date.getTime();

      this.datas.push([
        timestamp,        
        this.quotes[i].lastTrade]
      );            
    };
    console.log(this.datas);    
  }

}

export interface IQuotes {
  security: string;
  //  ask: number;
  //  bid: number;
  lastTrade: number;
  quoteDateTime: string;
}
