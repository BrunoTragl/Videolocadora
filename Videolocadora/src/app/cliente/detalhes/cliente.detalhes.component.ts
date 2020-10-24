import { Component, ElementRef, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/models/cliente.model';
import { ClienteService } from 'src/app/services/cliente.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-cliente-detalhes',
  templateUrl: './cliente.detalhes.component.html',
  styleUrls: ['./cliente.detalhes.component.css']
})
export class ClienteDetalhesComponent implements OnInit {
  
  id: number;
  cadastrado: string;
  ativo: boolean;
  foneMask = '(00) 0000-0000';
  clienteForm: FormGroup = this._formBulider.group({  
    nome: ['', [Validators.required]],
    sobrenome: ['', [Validators.required]],  
    nascimento: [''],
    email: [''],
    telefone: ['']
  });
  mensagemRetorno: string = '';
  exibirMensagemRetorno: boolean = false;
  constructor(private _activatedRoute: ActivatedRoute,
              private _clienteService: ClienteService,
              private _formBulider: FormBuilder,
              private _tratamentoDados: TratamentoDadosService,
              private _router: Router) {
      this.id = _activatedRoute.snapshot.params.id;
  }

  ngOnInit() {
    this.getCliente();
  }

  private getCliente() {
    this._clienteService.getById(this.id.toString()).subscribe((ret) => {
      this.cadastrado = this._tratamentoDados.getDataString(ret.data.cadastro.toString());
      this.ativo = ret.data.ativo.toString() === 'true';
      this.clienteForm = this._formBulider.group({
        nome: [ret.data.nome, [Validators.required]],
        sobrenome: [ret.data.sobrenome, [Validators.required]],  
        nascimento: [this._tratamentoDados.getDataString(ret.data.nascimento.toString())],
        email: [ret.data.email, [Validators.email]],
        telefone: [ret.data.telefone]
      });
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao buscar os dados do cliente!';
    });
  }

  onSubmit() {
    let cliente = new Cliente();
    cliente.nome = this.clienteForm.value.nome;
    cliente.sobrenome = this.clienteForm.value.sobrenome;
    cliente.email = this.clienteForm.value.email;
    cliente.telefone = this.clienteForm.value.telefone;
    cliente.nascimento = this._tratamentoDados.getDateNascimento(this.clienteForm.value.nascimento);

    this._clienteService.edit(this.id.toString(), cliente).subscribe(() => {
      this.mensagemRetorno = 'Alterações salvo com sucesso!';
      this.exibirMensagemRetorno = true;
    },
      (err) => {
        console.log(err);
        this.mensagemRetorno = 'Ocorreu um erro ao salvar os dados do cliente.';
        this.exibirMensagemRetorno = true;
      });
  }

  onChangeFone(){
    this.foneMask = this._tratamentoDados.maskAdapterFone(this.clienteForm.value.telefone);
  }

  alterarSituacao(){
    if(this.ativo) {
      this._clienteService.deleteById(this.id.toString()).subscribe(()=>{
        this.mensagemRetorno = 'Cliente desativado com sucesso!';
        this.exibirMensagemRetorno = true;
        this.getCliente();
      },
      (err) => {
        console.log(err);
        this.mensagemRetorno = 'Ocorreu um erro ao desativar cliente.';
        this.exibirMensagemRetorno = true;
      });
    } else {
      this._clienteService.activeById(this.id.toString()).subscribe(()=>{
        this.mensagemRetorno = 'Cliente ativado com sucesso!';
        this.exibirMensagemRetorno = true;
        this.getCliente();
      },
      (err) => {
        console.log(err);
        this.mensagemRetorno = 'Ocorreu um erro ao desativar cliente.';
        this.exibirMensagemRetorno = true;
      });
    }
  }

  enterRegistroFilmes(){
    this._router.navigate([`/clientes/detalhes/registrar-filmes/${this.id}`]);
  }
}