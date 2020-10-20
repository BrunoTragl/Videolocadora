import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError  } from 'rxjs'; 
import { retry, catchError } from 'rxjs/operators';
import { Funcionario } from '../models/funcionario.model'; 
import { Data } from '../models/data.model';
var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {
  url = 'https://localhost:44306/api/funcionario';  
  
  constructor(private http: HttpClient) { }

  getFuncionarioById(id: string): Observable<Data<Funcionario>> {  
    return this.http.get<Data<Funcionario>>(`${this.url}/${id}`)
               .pipe(
                    retry(2),
                    catchError(this.handleError)
                );  
  }
  getFuncionarioByCredencial(login: string, senha: string): any {  
    return this.http.post(this.url, {"login": login, "senha": senha}, httpOptions);  
  } 
  createFuncionario(funcionario: Funcionario): Observable<Funcionario> {  
    return this.http.post<Funcionario>(this.url, funcionario, httpOptions);  
  }  
  editFuncionario(funcionarioId: string, funcionario: Funcionario): Observable<Funcionario> {  
    const apiurl = `${this.url}/${funcionarioId}`;
    return this.http.put<Funcionario>(apiurl,funcionario, httpOptions);  
  }  
  deleteFuncionarioById(funcionarioId: string): Observable<number> {  
    const apiurl = `${this.url}/${funcionarioId}`;
    return this.http.delete<number>(apiurl, httpOptions);
  }  
  changePassword(funcionarioId: string, novaSenha: string): Observable<number> {  
    const apiurl = `${this.url}/${funcionarioId}`;
    return this.http.patch<number>(apiurl, novaSenha, httpOptions);  
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