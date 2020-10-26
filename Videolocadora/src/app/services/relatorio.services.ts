import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Data } from '../models/data.model';
import { ApiUrlService } from './api-url.service';
import { Aluguel } from '../models/aluguel.model';

@Injectable({
  providedIn: 'root'
})
export class RelatorioService {
  
  constructor(private http: HttpClient, private _apiUrl: ApiUrlService) { }

  getAlugueisAtivos(): Observable<Data<Aluguel[]>> {  
    return this.http.get<Data<Aluguel[]>>(`${this._apiUrl.relatorio}/alugueis-ativos`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getClientesInadimplentes(): Observable<Data<Aluguel[]>> {  
    return this.http.get<Data<Aluguel[]>>(`${this._apiUrl.relatorio}/clientes-inadimplentes`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  handleError(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Erro ocorreu no lado do client
      errorMessage = error.error.message;
    } else {
      // Erro ocorreu no lado do servidor
      errorMessage = `Código do erro: ${error.status}, ` + `menssagem: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  };
}