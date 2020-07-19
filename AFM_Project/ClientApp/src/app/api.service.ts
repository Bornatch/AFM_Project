import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { SecurityService } from './shared/components/security/security.service';
//Interfaces
import { IQuotes } from './shared/widgets/quotes-histories/quotes-histories.component'
import { IEodData } from './shared/widgets/performences/performences.component'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient,
    private securityService: SecurityService) { }

  //QuotesHistories Controllers
  public getQuotesHistories(security: string) {   
    return this.httpClient.get<IQuotes[]>('api/QuotesHistories/' + security);
  }
  public getQuotesHistoriesSecurities() {    
    return this.httpClient.get<string[]>('api/QuotesHistories');
  }

  //performences
  public GetEoddata(){
    return this.httpClient.get<IEodData[]>('api/Eoddatas')
  }

}

interface ISecurities {
  id_security: number
  ; security: string
  ; id_sector: number
  ; id_industry: number
  ; id_subindustry: number
  ; companyName: string
  ; volatility: number
  ; marketCap: number
  ; volLowest: number
  ; volAverage: number
  ; lastUpdate: string
}

