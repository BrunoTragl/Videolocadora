import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Cliente } from 'src/app/models/cliente.model';
import { ClienteParameters } from 'src/app/models/cliente.parameters.model';
import { Data } from 'src/app/models/data.model';
import { ClienteService } from 'src/app/services/cliente.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-cliente-buscar',
  templateUrl: './cliente.buscar.component.html',
  styleUrls: ['./cliente.buscar.component.css']
})
export class ClienteBuscarComponent implements OnInit {

  public clientes: Cliente[] = [];
  public buscarClienteForm: FormGroup = this._formBulider.group({  
    nome: ['', [Validators.required]],
    sobrenome: ['', [Validators.required]]
  });

  public exibirMensagemRetorno: boolean = false;
  public mensagemRetorno: string = '';
  private _initialSkip: number = 0;
  private _initialTake: number = 8;
  private skip: number;
  private take: number;
  public showMoreClientes: boolean = false;
  constructor(private _router: Router, 
              private _formBulider: FormBuilder,
              private _clienteService: ClienteService,
              public _tratamentoDadosService: TratamentoDadosService) { }

  ngOnInit() {
    this.initialClientes();
  }

  enterCliente(id: number){
    this._router.navigate([`clientes/detalhes/${id}`]);
  } 

  initialClientes(){
    this.configSearch();
    this._clienteService.getPagination(' ', ' ', this.skip, this.take).subscribe((ret) => {
      this.pushClientes(ret);
    },
    (err) => {
      this.error(err);
    });
  }

  seachClientes(){
    this.configSearch();
    let parameters = this.getParameters();
    this._clienteService.getPagination(parameters.nome, parameters.sobrenome, this.skip, this.take).subscribe((ret) => {
      if(ret.data.length === 0){
        this.exibirMensagemRetorno = true;
        this.mensagemRetorno = 'Não houve resultados para esta palavra-chave.';
      }
      else {
        this.pushClientes(ret);
      }
    },
    (err) => {
      this.error(err);
    });
  }

  moreClientes(){
    this.clearMessageError();
    this.skip += this.take;
    let parameters = this.getParameters();
    this._clienteService.getPagination(parameters.nome, parameters.sobrenome, this.skip, this.take).subscribe((ret) => {
      this.pushClientes(ret);
    },
    (err) => {
      this.error(err);
    });
  }

  private pushClientes(ret: Data<Cliente[]>){
    this.showMoreClientes = ret.data.length == this.take;
    ret.data.forEach((cliente) => {
      this.clientes.push(cliente);
    },
    (err) => {
      this.error(err);
    });
  }

  private error(err: any){
    console.log(err);
    this.exibirMensagemRetorno = true;
    this.mensagemRetorno = "Ocorreu um erro ao buscar clientes!"
    this.showMoreClientes = false;
  }

  private configSearch(){
    this.clientes = [];
    this.skip = this._initialSkip;
    this.take = this._initialTake;
    this.showMoreClientes = false;
    this.clearMessageError();
  }

  private clearMessageError(){
    this.exibirMensagemRetorno = false;
    this.mensagemRetorno = ""
  }

  private getParameters() : ClienteParameters {
    let nome = this.buscarClienteForm.value.nome;
    let sobrenome = this.buscarClienteForm.value.sobrenome;
    if (!nome && !sobrenome) {
      nome = ' ';
      sobrenome = ' ';
    }
    return new ClienteParameters(nome, sobrenome);
  }

}