import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm = new FormGroup({
    login: new FormControl('', Validators.required),
    senha: new FormControl('', Validators.required),
  });

  showErrorMessage: boolean;
  errorMessage: string;

  constructor(private _authentication: AuthenticationService, private _router: Router) { }
  
  ngOnInit() {
    this.showErrorMessage = false;
  }

  onSubmit() {
    this._authentication.login(this.loginForm.value.login, this.loginForm.value.senha).subscribe(()=>{
      this._router.navigate(['/']);
    },
    err => {
      console.log(err);
      if(err.status === 404){
        this.errorMessage = err.error;
      } else {
        this.errorMessage = 'Ocorreu um erro interno, tente mais tarde.';
      }
      this.showErrorMessage = true;
    });
  }

}