import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Data } from '../models/data.model';
import { ApiUrlService } from './api-url.service';
import { Cliente } from '../models/cliente.model';
var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  
  constructor(private http: HttpClient, private _apiUrl: ApiUrlService) { }

  getById(id: string): Observable<Data<Cliente>> {  
    return this.http.get<Data<Cliente>>(`${this._apiUrl.cliente}/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getPagination(nome: string, sobrenome: string, skip: number, take: number){
    return this.http.post<Data<Cliente[]>>(`${this._apiUrl.cliente}/list`, {"nome": nome,"sobrenome": sobrenome, "skip": skip, "take": take}, httpOptions);
  }
  create(cliente: Cliente): Observable<Data<Cliente>> {  
    return this.http.post<Data<Cliente>>(this._apiUrl.cliente, cliente, httpOptions);  
  }  
  edit(clienteId: string, cliente: Cliente): Observable<Data<Cliente>> {  
    const apiurl = `${this._apiUrl.cliente}/${clienteId}`;
    return this.http.put<Data<Cliente>>(apiurl, cliente, httpOptions);  
  }  
  deleteById(clienteId: string): Observable<number> {  
    const apiurl = `${this._apiUrl.cliente}/${clienteId}`;
    return this.http.delete<number>(apiurl, httpOptions);
  }
  activeById(clienteId: string): Observable<number> {  
    const apiurl = `${this._apiUrl.cliente}/${clienteId}`;
    return this.http.patch<number>(apiurl, httpOptions);
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