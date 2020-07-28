import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { SecurityService } from './shared/components/security/security.service';
//Interfaces
import { IQuotes } from './shared/widgets/quotes-histories/quotes-histories.component'
import { IPortfolio, IPortfolioName } from './shared/widgets/performences/performences.component'
import { IEodIndex } from './shared/widgets/performences-index/performences-index.component'

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

  //performences portfolio
  public GetUserPortfolio(idMetaUser : string) {
    return this.httpClient.get<IPortfolio[]>('api/Eoddatas/getUserPortfolioPerf/' + idMetaUser)
  }

  public GetUserPortfoliosName(idMetaUser : string) {
    return this.httpClient.get<IPortfolioName[]>('api/Customers/' + idMetaUser );
  }

  //performences Index
  public GetEodIndexes() {
    return this.httpClient.get<IEodIndex[]>('api/Eodindexes')
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

