import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as Highcharts from 'highcharts';

@Component({
  selector: 'app-widget-quotes-histories',
  templateUrl: './quotes-histories.component.html',
  styleUrls: ['./quotes-histories.component.scss']
})
export class QuotesHistoriesComponent implements OnInit {

  chartOptions: {};
  Highcharts = Highcharts;
  quotes: Quotes[];
  datas = new Array<any>();

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Quotes[]>(baseUrl + 'api/QuotesHistories/amzn').subscribe(result => {
      this.quotes = result;
      this.setData();
    }, error => console.error(error));

  }

  ngOnInit() {
    this.chartOptions = {
      chart: {
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
      }]

    };
    
  }

  setData() {

    for (let i = 0; i < this.quotes.length; i++) {
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

interface Quotes {
  //  Security: string;
  //  ask: number;
  //  bid: number;
  lastTrade: number;
  quoteDateTime: string;
}
