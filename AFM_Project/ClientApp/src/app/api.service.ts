import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//Interfaces
import { IQuotes } from './shared/widgets/quotes-histories/quotes-histories.component'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  @Inject('BASE_URL') baseUrl: string;

  constructor(private httpClient: HttpClient) { }

  //QuotesHistories Controllers
  public getQuotesHistories(security:string) {
    return this.httpClient.get<IQuotes[]>('api/QuotesHistories/' + security);
  }

  public getQuotesHistoriesSecurities() {
    return this.httpClient.get<string[]>('api/QuotesHistories');
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

