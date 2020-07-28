import { Component, OnInit, OnChanges, SimpleChanges } from '@angular/core';
import * as Highcharts from 'highcharts/highstock';
import { ApiService } from '../../../api.service';
import { SecurityService } from '../../components/security/security.service';
import { AppUserAuth } from '../../components/security/app-user-auth';
import { ThemePalette } from '@angular/material';

@Component({
  selector: 'app-widget-performences',
  templateUrl: './performences.component.html',
  styleUrls: ['./performences.component.scss']
})
export class PerformencesComponent implements OnChanges {

  //Chart info
  Highcharts = Highcharts;
  chartConstructor = 'stockChart';
  chartOptions: {};

  //charts'data 
  portfolios: IPortfolio[];
  datas = new Array<any>();
  seriesOptions = [];
  arrayPortfolio = [];

  //myControl = new FormControl();
  //filteredOptions: Observable<string[]>;

  //checkbox
  task: Task;
  subtasks = [];
  portfoliosName: IPortfolioName[];
  allComplete: boolean = false;

  //get user
  securityObject: AppUserAuth;
  constructor(
    private apiService: ApiService,
    private _securityService: SecurityService) {
    this._securityService.messageSecurity.subscribe((message: AppUserAuth) => {
      this.securityObject = message;
    });
    this.setTask();
  }
  ngOnChanges(changes: SimpleChanges): void {    
    // build chart
    this.addValueToChart();
  }

  ngOnInit() {
    if (this.securityObject.isAdmin) {
      //api avec tout
    }
    if (this.securityObject.isUser) {
      this.apiService.GetUserPortfoliosName(this.securityObject.idMetaUser).subscribe(result => {
        this.portfoliosName = result
        this.setCheckboxSubtask();
      }, error => console.error(error))
    }
    // build chart
    this.success();
  }

  setChart() {
    console.log("appel de set chart...")
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
    console.log(this.chartOptions)
  }

  private success() {
    this.apiService.GetUserPortfolio(this.securityObject.idMetaUser).subscribe(result => {
      this.portfolios = result;
      this.setData();
    }, error => console.error(error))

  }

  setData() {
    //loop sur les valeurs de tous les portefeuilles du client final
    for (let index = 0; index < this.portfolios.length; index++) {
      //sortir les valeurs à 0 ....
      if (this.portfolios[index].value != 0) {
        //pour chaque valeur, créer une liste dans arryPortfolio pour isoler chaque portefeuile
        for (let i = 0; i < this.portfoliosName.length; i++) {
          if (this.portfolios[index].portfolioName == this.portfoliosName[i].portfolioname) {
            this.arrayPortfolio[i].push(
              [
                new Date(this.portfolios[index].dateStamp).getTime(),
                this.portfolios[index].value
              ])
          }
        }
      }
    }
    this.addValueToChart();
  }

  addValueToChart() {
    console.log("appel de addvalue...")
    //clear data
    this.seriesOptions = []
    // mise des données triées dane les series options pour Highcharts
    for (let index = 0; index < this.arrayPortfolio.length; index++) {      
      if (this.subtasks[index].completed) {
        this.seriesOptions[index] = {
          name: this.portfoliosName[index].username,
          data: this.arrayPortfolio[index]
        }        
      }
    }
    console.log(this.seriesOptions)
    this.setChart();
  }

  updateAllComplete() {
    this.allComplete = this.task.subtasks != null && this.task.subtasks.every(t => t.completed);
    this.addValueToChart();
  }

  //checkbox
  setTask() {
    this.task = {
      name: 'Portfolios',
      completed: false,
      color: 'primary',
      subtasks: this.subtasks
    }
  }

  setCheckboxSubtask() {
    let str
    let poolIndex
    let algoIndex
    let sellingIndex

    for (let i = 0; i < this.portfoliosName.length; i++) {
      //set type from AccountNickname
      str = this.portfoliosName[i].portfolioname
      poolIndex = this.IndexOfNth(str, '_', 0)
      algoIndex = this.IndexOfNth(str, '_', 1)
      sellingIndex = this.IndexOfNth(str, '_', 2)
      this.portfoliosName[i].poolType = str.substr(0, algoIndex)
      this.portfoliosName[i].algoType = str.substr(algoIndex + 1, str.indexOf('_') - 1)
      this.portfoliosName[i].sellingType = str.substr(sellingIndex + 1, str.indexOf('_'))

      this.subtasks[i] = {
        name: this.portfoliosName[i].username,
        completed: true,
        color: 'primary'
      }
      this.arrayPortfolio.push([]);
    }
  }

  IndexOfNth(str: string, delimiter: string, nth: number) {
    if (nth < 0 || str == null) {
      return 0;
    }

    let offset = str.indexOf(delimiter);
    for (let i = 0; i < nth; i++) {
      if (offset == -1) return -1;
      offset = str.indexOf(delimiter, offset + 1);
    }
    return offset;
  }

  someComplete(): boolean {
    if (this.task.subtasks == null) {
      return false;
    }
    return this.task.subtasks.filter(t => t.completed).length > 0 && !this.allComplete;
  }

  setAll(completed: boolean) {
    this.allComplete = completed;
    if (this.task.subtasks == null) {
      return;
    }
    this.task.subtasks.forEach(t => t.completed = completed);
    this.addValueToChart();
  }
}

export interface IPortfolio {
  portfolioName: string
  dateStamp: string
  value: number
}

export interface IPortfolioName {
  username: string
  portfolioname: string
  poolType: string
  algoType: string
  sellingType: string
}

export interface Task {
  name: string;
  completed: boolean;
  color: ThemePalette;
  subtasks?: Task[];
}

/*
export interface IEodData {
  id: number
  dateStamp: number
  portfolio: string
  nbShares: number
  cash: number
  capitalIncrease: number
  botSold: number
}
*/
