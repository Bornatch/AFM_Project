import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as Highcharts from 'highcharts/highstock';
import { ApiService } from '../../../api.service'

@Component({
  selector: 'app-widget-quotes-histories',
  templateUrl: './quotes-histories.component.html',
  styleUrls: ['./quotes-histories.component.scss']
})
export class QuotesHistoriesComponent implements OnInit {

  chartOptions: {};

  Highcharts = Highcharts;
  public chart: any;
  quotes: IQuotes[];
  datas = new Array<any>();

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getQuotesHistories().subscribe(result => {
      this.quotes = result;
      this.setData();
      this.chartOptions = {
        rangeSelector: {
          selected: 1
        },

        title: {
          text: 'AAPL Stock Price'
        },

        series: [{
          name: 'AAPL',
          data: this.datas,
          tooltip: {
            valueDecimals: 2
          }
        }]
      
        /*chart: {
          type: 'line'
        },
        title: {
          text: 'Action course'
        },
        xAxis: {
          type: 'category',
          labels: {
            rotation: -45,
            style: {
              fontSize: '13px',
              fontFamily: 'Verdana, sans-serif'
            }
          }
        },
        yAxis: {
          min: 0,
          title: {
            text: 'price'
          }
        },
        legend: {
          enabled: false
        },
        tooltip: {
          pointFormat: 'Price: <b>{point.y:.2f}</b>'
        },

        series: [{
          type: 'line',
          name: 'AMZN StockPrice',
          data: this.datas,
          marker: {
            enabled: true,
            radius: 3
          },
          shadow: true,
          tooltip: {
            valueDecimals: 2
          },
          turboThreshold: 25000
        }]*/

      };   
    }, error => console.error(error));
  }

    

  setData() {

    for (let i = 0; i < this.quotes.length; i++) {
      let date = new Date(this.quotes[i].quoteDateTime);
      let timestamp = date.getTime();

      this.datas.push([
        //timestamp,
        date,
        //this.quotes[i].quoteDateTime,
        this.quotes[i].lastTrade]
      );
            
    };
    console.log(this.datas);
    
  }

}

interface IQuotes {
  //  Security: string;
  //  ask: number;
  //  bid: number;
  lastTrade: number;
  quoteDateTime: string;
}
