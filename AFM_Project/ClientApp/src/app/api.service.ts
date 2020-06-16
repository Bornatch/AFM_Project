import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

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

interface IQuotes {
  //  Security: string;
  //  ask: number;
  //  bid: number;
  lastTrade: number;
  quoteDateTime: string;
}

