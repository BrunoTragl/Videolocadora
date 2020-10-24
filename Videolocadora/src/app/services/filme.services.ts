import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Data } from '../models/data.model';
import { ApiUrlService } from './api-url.service';
import { Filme } from '../models/filme.model';
var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class FilmeService {
  
  constructor(private http: HttpClient, private _apiUrl: ApiUrlService) { }

  getById(id: string): Observable<Data<Filme>> {  
    return this.http.get<Data<Filme>>(`${this._apiUrl.filme}/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getPagination(titulo: string, skip: number, take: number){
    return this.http.post<Data<Filme[]>>(`${this._apiUrl.filme}/list`, {"titulo": titulo, "skip": skip, "take": take}, httpOptions);
  }
  getPaginationUnselectedFilmes(titulo: string, skip: number, take: number, filmesSelecionados: Filme[]){
    return this.http.post<Data<Filme[]>>(`${this._apiUrl.filme}/unselected`, {"titulo": titulo, "skip": skip, "take": take, "filmesSelecionados": filmesSelecionados}, httpOptions);
  }
  create(filme: Filme): Observable<Data<Filme>> {  
    return this.http.post<Data<Filme>>(this._apiUrl.filme, filme, httpOptions);  
  }  
  edit(filmeId: string, filme: Filme): Observable<Data<Filme>> {  
    const apiurl = `${this._apiUrl.filme}/${filmeId}`;
    return this.http.put<Data<Filme>>(apiurl, filme, httpOptions);  
  }  
  deleteById(filmeId: string): Observable<number> {  
    const apiurl = `${this._apiUrl.filme}/${filmeId}`;
    return this.http.delete<number>(apiurl, httpOptions);
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