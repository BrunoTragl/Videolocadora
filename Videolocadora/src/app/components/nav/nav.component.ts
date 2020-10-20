import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Funcionario } from 'src/app/models/funcionario.model';
import { AuthenticationService } from '../../services/authentication.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html'
})

export class NavComponent implements OnInit{

  constructor(private _authentication: AuthenticationService) { }

  public formUser = new FormGroup({
    nome: new FormControl('', Validators.required),
    senha: new FormControl('', Validators.required),
  });

  public funcionario: Funcionario;

  ngOnInit(): void {
    this.funcionario = this._authentication.currentUserValue.data;
    let userLinkBar:HTMLElement = document.querySelector('#navbarDropdownMenuLinkUser');
    userLinkBar.innerText = this.funcionario.nome;

  }


  sair(){
    this._authentication.logout();
  }



}