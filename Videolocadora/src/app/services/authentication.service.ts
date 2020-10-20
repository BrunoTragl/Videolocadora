import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiUrl } from './api-url'

import { User } from '../models/user.model';
import { Funcionario } from '../models/funcionario.model';
import { Data } from '../models/data.model';

@Injectable({ 
    providedIn: 'root' 
})

export class AuthenticationService {
    private currentUserSubject: BehaviorSubject<Data<Funcionario>>;
    public currentUser: Observable<Data<Funcionario>>;
    private apiUrl: ApiUrl;

    constructor(private http: HttpClient) {
        this.currentUserSubject = new BehaviorSubject<Data<Funcionario>>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
        this.apiUrl = new ApiUrl();
    }

    public get currentUserValue(): Data<Funcionario> {
        return this.currentUserSubject.value;
    }

    login(login, senha) {
        return this.http.post<any>(this.apiUrl.login, { login, senha })
            .pipe(
                map(user => {
                    localStorage.setItem('currentUser', JSON.stringify(user));
                    this.currentUserSubject.next(user);
                    return user;
                })
            );
    }

    logout() {
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
}