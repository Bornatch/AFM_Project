import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/api.service';
import { AppUserAuth } from '../../components/security/app-user-auth';
import { SecurityService } from '../../components/security/security.service';

@Component({
  selector: 'app-widget-statistic',
  templateUrl: './statistic.component.html',
  styleUrls: ['./statistic.component.scss']
})

export class StatisticComponent implements OnInit {

  //get user
  securityObject: AppUserAuth;

  //datas
  tradedDatas: ITradedStats[];
  portfoliosData = [];
  username = [];


  constructor(private apiService: ApiService,
    private _securityService: SecurityService) {
    this._securityService.messageSecurity
      .subscribe((message: AppUserAuth) => {
        this.securityObject = message
      }, error => console.error(error));
  }

  ngOnInit() {
    if (this.securityObject.isAdmin) {
      this.apiService.getAllPortfolioStat()
        .subscribe(result => {
          this.tradedDatas = result;
          this.setData();
        }
          , error => console.error(error))
      }
    if (this.securityObject.isUser) {
    this.apiService.getUserPortfolioStat(this.securityObject.idMetaUser)
      .subscribe(result => {
        this.tradedDatas = result;
        this.setData();
      }
        , error => console.error(error))
    }
    this.setData();
  }

  setData() {
    console.log(this.tradedDatas.length)
    //let username = []
    for (let index = 0; index < this.tradedDatas.length; index++) {
      let cell = this.tradedDatas[index]
      let i = 0
      for ( i ; i < this.username.length; i++) {
        if (this.tradedDatas[index].userName == this.username[i]) {
          this.portfoliosData[i].push([
            cell.daySinceCreation,
            cell.executedSaving,
            cell.gicsSector,
            cell.stopLoss,
            new Date(cell.tradedDate).getTime(),
          ])
          cell.saisie = true
        }
      }    

      if (!cell.saisie) {
        this.portfoliosData.push([])
        this.username.push(cell.userName);

        this.portfoliosData[i].push([
          cell.daySinceCreation,
          cell.executedSaving,
          cell.gicsSector,
          cell.stopLoss,
          new Date(cell.tradedDate).getTime(),
        ])
        cell.saisie = true
      }
    }
    
    for (let index = 0; index < this.portfoliosData.length; index++) {      
        this.username[index].push(this.portfoliosData[index]) 
        
      
    }

  }

}

export interface ITradedStats {
  userName: string;
  executedSaving: number;
  sell: string;
  stopLoss: boolean;
  tradedDate: string;
  daySinceCreation: number;
  gicsSector: string
  saisie: boolean
}
