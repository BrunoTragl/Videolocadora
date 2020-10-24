import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cliente } from 'src/app/models/cliente.model';
import { ClienteService } from 'src/app/services/cliente.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-cliente-novo',
  templateUrl: './cliente.novo.component.html',
  styleUrls: ['./cliente.novo.component.css']
})
export class ClienteNovoComponent implements OnInit {
  exibirMensagemRetorno: boolean = false;
  mensagemRetorno: string = '';
  foneMask = '(00) 0000-0000';
  novoClienteForm: FormGroup = this._formBulider.group({  
    nome: ['', [Validators.required]],
    sobrenome: ['', [Validators.required]],  
    nascimento: [''],
    email: ['', [Validators.email]],
    telefone: ['']
  });

  constructor(private _clienteService: ClienteService, 
              private _formBulider: FormBuilder,
              private _tratamentoDados: TratamentoDadosService) { }

  ngOnInit() {
    
  }

  onSubmit(){
    let cliente = new Cliente();
    cliente.nome = this.novoClienteForm.value.nome;
    cliente.sobrenome = this.novoClienteForm.value.sobrenome;
    cliente.email = this.novoClienteForm.value.email;
    cliente.telefone = this.novoClienteForm.value.telefone;
    cliente.nascimento = this._tratamentoDados.getDateNascimento(this.novoClienteForm.value.nascimento);

    this._clienteService.create(cliente).subscribe(() => {
      this.mensagemRetorno = 'Cliente criado com sucesso!';
      this.exibirMensagemRetorno = true;
    },
    (err) => {
      console.log(err);
      this.mensagemRetorno = 'Ocorreu um erro ao criar o cliente.';
      this.exibirMensagemRetorno = true;
    });
  }

  onChangeFone(){
    this.foneMask = this._tratamentoDados.maskAdapterFone(this.novoClienteForm.value.telefone);
  }
}




