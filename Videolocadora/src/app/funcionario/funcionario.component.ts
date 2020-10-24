
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';  
import { Funcionario } from 'src/app/models/funcionario.model';
import { AuthenticationService } from '../services/authentication.service';
import { TratamentoDadosService } from '../services/tratamento.dados.services';
import { FuncionarioService } from '../services/funcionario.services';
;

@Component({
  selector: 'app-funcionario',
  templateUrl: './funcionario.component.html',
  styleUrls: ['./funcionario.component.css']
})
export class FuncionarioComponent implements OnInit {

  funcionarioForm: FormGroup;
  funcionario: Funcionario;
  public exibirMensagemRetorno: boolean = false;
  public mensagemRetorno: string = '';

  constructor(private formBulider: FormBuilder, 
              private _authenticationService: AuthenticationService, 
              private _tratamentoDados: TratamentoDadosService,
              private _funcionarioService: FuncionarioService) { }

  ngOnInit() {
    this.getFuncionario();
  }

  getFuncionario(){
    this.funcionario = this._authenticationService.currentUserValue.data
    this.funcionarioForm = this.formBulider.group({  
      login: [this.funcionario.login],
      nome: [this.funcionario.nome, [Validators.required]],  
      sobrenome: [this.funcionario.sobrenome, [Validators.required]],
      email: [this.funcionario.email, [Validators.required, Validators.email]]
    });

    let cadastro:HTMLElement = document.querySelector('#cadastro');
    let dataCadastro = this._tratamentoDados.getDataString(this.funcionario.cadastro);
    cadastro.innerText = `desde ${dataCadastro}`;
  }

  onSubmit(){
    this.exibirMensagemRetorno = false;
    let editedFuncionario: Funcionario = this.funcionario;
    editedFuncionario.nome = this.funcionarioForm.value.nome;
    editedFuncionario.sobrenome = this.funcionarioForm.value.sobrenome;
    editedFuncionario.email = this.funcionarioForm.value.email;

    this._funcionarioService.edit(this.funcionario.id.toString(), editedFuncionario)
          .subscribe(() => {
            this.mensagemRetorno = 'Dados salvos com sucesso!';
            this.exibirMensagemRetorno = true;
          },
          (err) => {
            console.log(err);
            this.mensagemRetorno = 'Ocorreu um erro, não foi possível salvar as alterações!';
            this.exibirMensagemRetorno = true;
          });
  }
}