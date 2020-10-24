import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Funcionario } from '../models/funcionario.model'; 
import { Data } from '../models/data.model';
import { ApiUrlService } from './api-url.service';
var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {
  
  constructor(private http: HttpClient, private _apiUrl: ApiUrlService) { }

  getById(id: string): Observable<Data<Funcionario>> {  
    return this.http.get<Data<Funcionario>>(`${this._apiUrl.funcionario}/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getByCredencial(login: string, senha: string): any {  
    return this.http.post(this._apiUrl.funcionario, {"login": login, "senha": senha}, httpOptions);  
  } 
  create(funcionario: Funcionario): Observable<Funcionario> {  
    return this.http.post<Funcionario>(this._apiUrl.funcionario, funcionario, httpOptions);  
  }  
  edit(funcionarioId: string, funcionario: Funcionario): Observable<Funcionario> {  
    const apiurl = `${this._apiUrl.funcionario}/${funcionarioId}`;
    return this.http.put<Funcionario>(apiurl,funcionario, httpOptions);  
  }  
  deleteById(funcionarioId: string): Observable<number> {  
    const apiurl = `${this._apiUrl.funcionario}/${funcionarioId}`;
    return this.http.delete<number>(apiurl, httpOptions);
  }  
  changePassword(funcionarioId: string, novaSenha: string): Observable<Funcionario> {  
    const apiurl = `${this._apiUrl.funcionario}/${funcionarioId}`;
    return this.http.patch<Funcionario>(apiurl, {"senha": novaSenha}, httpOptions);  
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