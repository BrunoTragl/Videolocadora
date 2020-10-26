import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Data } from '../models/data.model';
import { ApiUrlService } from './api-url.service';
import { Aluguel } from '../models/aluguel.model';
import { Multa } from '../models/multa.model';
import { AluguelGratuito } from '../models/aluguel-gratuito.model';
var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class AluguelService {
  
  constructor(private http: HttpClient, private _apiUrl: ApiUrlService) { }

  getById(id: string): Observable<Data<Aluguel>> {  
    return this.http.get<Data<Aluguel>>(`${this._apiUrl.aluguel}/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getByCliente(clienteId: string): Observable<Data<Aluguel[]>> {  
    return this.http.get<Data<Aluguel[]>>(`${this._apiUrl.aluguel}/bycliente/${clienteId}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getAluguelGratuito(clienteId: string): Observable<Data<AluguelGratuito>> {  
    return this.http.get<Data<AluguelGratuito>>(`${this._apiUrl.aluguel}/gratuito/${clienteId}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getMulta(id: string): Observable<Data<Multa>> {  
    return this.http.get<Data<Multa>>(`${this._apiUrl.aluguel}/multa/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  create(aluguel: Aluguel): Observable<Data<Aluguel>> {  
    return this.http.post<Data<Aluguel>>(this._apiUrl.aluguel, aluguel, httpOptions);  
  }  
  edit(aluguelId: number,aluguel: Aluguel): Observable<Data<Aluguel>> {  
    const apiurl = `${this._apiUrl.aluguel}/${aluguelId}`;
    return this.http.put<Data<Aluguel>>(apiurl, aluguel, httpOptions);  
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