import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, ElementRef, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Cliente } from 'src/app/models/cliente.model';
import { Filme } from 'src/app/models/filme.model';
import { ClienteService } from 'src/app/services/cliente.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-cliente-registrar-filmes',
  templateUrl: './cliente.registrar-filmes.component.html',
  styleUrls: ['./cliente.registrar-filmes.component.css']
})
export class ClienteRegistrarFilmesComponent implements OnInit {  ////PAI
  id: number;
  cliente: Cliente = new Cliente();
  valorTotalAluguel: number = 0.00;
  filmesParaAlugar: Filme[] = []; //ENVIAR ESTE PARA O FILHO

  filmesForm: FormGroup = this._formBulider.group({  
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
              private _aluguel: ClienteService,
              private _formBulider: FormBuilder,
              public _tratamentoDados: TratamentoDadosService,
              private _element: ElementRef) {
      this.id = _activatedRoute.snapshot.params.id;
  }

  ngOnInit() {
    this.getCliente();
  }

  private getCliente() {
    this._clienteService.getById(this.id.toString()).subscribe((ret) => {
        this.cliente = ret.data;
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao buscar os dados do cliente!';
    });
  }

  onSubmit() {
    
  }

  getFilmesParaAlugar(filmes: Filme[]){
    this.valorTotalAluguel = 0;
    this.filmesParaAlugar = [];
    filmes.forEach((filme) => {
      this.filmesParaAlugar.push(filme);
      this.valorTotalAluguel += filme.valor;
    });
  }

  removeFilme(filme: Filme) {
    this.valorTotalAluguel = 0;
    let removeFilme = this.filmesParaAlugar.find(p => p.id == filme.id);
    let filmes: Filme[] = [];
    this.filmesParaAlugar.forEach((filme) => {
      if (filme !== removeFilme) {
        filmes.push(filme);
        this.valorTotalAluguel += filme.valor;
      }
    });
    this.filmesParaAlugar = filmes;
  }
}