import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/models/cliente.model';
import { Filme } from 'src/app/models/filme.model';
import { AluguelService } from 'src/app/services/aluguel.services';
import { ClienteService } from 'src/app/services/cliente.services';
import { RegistrarFilmeService } from 'src/app/services/registrar-filme.services';
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
  filmesSelecionados: Filme[] = []; //ENVIAR ESTE PARA O FILHO
  possuiAluguelGratuito: boolean = false;
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
              private _aluguelService: AluguelService,
              private _formBulider: FormBuilder,
              public _tratamentoDados: TratamentoDadosService,
              private _registrarFilmes: RegistrarFilmeService,
              private _router: Router) {
      this.id = _activatedRoute.snapshot.params.id;
  }

  ngOnInit() {
    this.getCliente();
  }

  private getCliente() {
    this._clienteService.getById(this.id.toString()).subscribe((ret) => {
        this.cliente = ret.data;
        this.getAluguelGratuito();
        this.getFilmesByLocalStorage();
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao buscar os dados do cliente!';
    });
  }

  continuar() {
    this._router.navigate([`clientes/finalizar/${this.id}`]);
  }

  public getFilmesSelecionados(filmes: Filme[]){
    this.valorTotalAluguel = 0;
    this.filmesSelecionados = [];
    filmes.forEach((filme) => {
      this.filmesSelecionados.push(filme);
      this.valorTotalAluguel += filme.valor;
    });
    this._registrarFilmes.set(filmes, this.cliente);
  }

  public removeFilme(filme: Filme) {
    this.valorTotalAluguel = 0;
    let removeFilme = this.filmesSelecionados.find(p => p.id == filme.id);
    let filmes: Filme[] = [];
    this.filmesSelecionados.forEach((filme) => {
      if (filme !== removeFilme) {
        filmes.push(filme);
        this.valorTotalAluguel += filme.valor;
      }
    });
    this.filmesSelecionados = filmes;
    this._registrarFilmes.set(filmes, this.cliente);
  }

  public cancelarRegistroFilmes(){
    this._registrarFilmes.remove(this.cliente);
    this._router.navigate(['clientes/buscar']);
  }

  private getFilmesByLocalStorage(){
    if (!this.cliente) {
      return;
    }

    let filmesStorage = this._registrarFilmes.get(this.cliente);
    if (filmesStorage) {
      this.valorTotalAluguel = 0;
      this.filmesSelecionados = [];
      filmesStorage.forEach((filme) => {
        this.filmesSelecionados.push(filme);
        this.valorTotalAluguel += filme.valor;
      });
    }
  }

  private getAluguelGratuito(){
    this._aluguelService.getAluguelGratuito(this.cliente.id.toString()).subscribe((ret)=>{
      this.possuiAluguelGratuito = ret.data.possuiAluguelGratuito;
    },
    (err)=>{
      console.log(err);
    })
  }
}