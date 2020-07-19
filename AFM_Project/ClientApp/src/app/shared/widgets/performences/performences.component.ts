import { Component, OnInit } from '@angular/core';
import * as Highcharts from 'highcharts';
import { ApiService } from '../../../api.service';

@Component({
  selector: 'app-performences',
  templateUrl: './performences.component.html',
  styleUrls: ['./performences.component.scss']
})
export class PerformencesComponent implements OnInit {

  //Chart info
  Highcharts = Highcharts;
  chartConstructor = 'stockChart';
  chartOptions: {};

  //charts'data 
  eodData: IEodData[];
  datas = new Array<any>();
  seriesOptions = [];
  seriesCounter = 0;
  names = ['MSFT', 'AAPL', 'GOOG'];
  //myControl = new FormControl();
  //filteredOptions: Observable<string[]>;



  constructor(private apiService: ApiService) { }

  ngOnInit() {
    // build chart
    this.setChart();
  }


  setChart() {
    this.apiService.GetEoddata().subscribe(result => {
      this.eodData = result;

      //Chart
      this.chartOptions = {
        rangeSelector: {
          selected: 1
        },
        yAxis: {
          labels: {
            formatter: function () {
              return (this.value > 0 ? ' + ' : '') + this.value + '%';
            }
          },
          plotLines: [{
            value: 0,
            width: 2,
            color: 'silver'
          }]
        },
        plotOptions: {
          series: {
            compare: 'percent',
            showInNavigator: true
          }
        },
        tooltip: {
          pointFormat: '<span style="color:{series.color}">{series.name}</span>: <b>{point.y}</b> ({point.change}%)<br/>',
          valueDecimals: 2,
          split: true
        },
      };

    }, error => console.error(error))
  }

  private success(data) {
    var name = this.url.match(/(msft|aapl|goog)/)[0].toUpperCase();
    var i = this.names.indexOf(name);
    this.seriesOptions[i] = {
      name: name,
      data: data
    };
  
    // As we're loading the data asynchronously, we don't know what order it
    // will arrive. So we keep a counter and create the chart when all the data is loaded.
    this.seriesCounter += 1;
  
    if (this.seriesCounter === this.names.length) {
      this.setChart();
    }
  }

}


export interface IEodData {
  id: number
  dateStamp: number
  portfolio: string
  nbShares: number
  cash: number
  capitalIncrease: number
  botSold: number
}
