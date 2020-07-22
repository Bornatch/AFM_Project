import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/api.service';
import * as Highcharts from 'highcharts/highstock';

@Component({
  selector: 'app-widget-performences-index',
  templateUrl: './performences-index.component.html',
  styleUrls: ['./performences-index.component.scss']
})
export class PerformencesIndexComponent implements OnInit {
  //Chart info
  Highcharts = Highcharts;
  chartConstructor = 'stockChart';
  chartOptions: {};

  //charts'data 
  eodIndex: IEodIndex[];
  datas = new Array<any>();
  seriesOptions = [];
  seriesCounter = 0;
  names = [' DJIA', ' SPX', ' DTX'];
  serieDjia = []
  serieSpx = []
  serieDTX = []
  //myControl = new FormControl();
  //filteredOptions: Observable<string[]>;



  constructor(private apiService: ApiService) { }

  ngOnInit() {
    // build chart
    this.success();
  }

  setChart() {
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
      series: this.seriesOptions
    };
  }

  private success() {
    
    this.apiService.GetEodIndexes().subscribe(result => {
      this.eodIndex = result;
      this.setData();

    }, error => console.error(error))


  }
  setData() {
    for (let index = 0; index < this.eodIndex.length; index++) {

      this.seriesOptions[0] = {
        name: 'DJIA',
        data: this.serieDjia.push([
          new Date(this.eodIndex[index].dateStamp).getTime(),
          this.eodIndex[index].djia
        ])
      }

      this.serieSpx.push([
        new Date(this.eodIndex[index].dateStamp).getTime(),
        this.eodIndex[index].spx
      ])

      this.serieDTX.push([
        new Date(this.eodIndex[index].dateStamp).getTime(),
        this.eodIndex[index].dtx
      ])

      if (index != 0 && index == this.eodIndex.length - 1) {
        this.seriesOptions[0] = {
          name: 'DJIA',
          data: this.serieDjia
        }

        this.seriesOptions[1] = {
          name: 'SPX',
          data: this.serieSpx
        }

        this.seriesOptions[2] = {
          name: 'DTX',
          data: this.serieDTX
        }

        this.setChart();

      }

    }
  }

}

export interface IEodIndex {
  id: number
  dateStamp: number
  djia: number
  spx: number
  dtx: number
  rut: number
  dux: number
  ecm: number
  rlx: number
}

