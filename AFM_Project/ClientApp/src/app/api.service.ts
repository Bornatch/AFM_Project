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

  public getQuotesHistories() {
    return this.httpClient.get<IQuotes[]>('api/QuotesHistories/amzn');
  }
}

