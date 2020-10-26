import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { timer } from 'rxjs';
import { Aluguel } from 'src/app/models/aluguel.model';
import { Cliente } from 'src/app/models/cliente.model';
import { Filme } from 'src/app/models/filme.model';
import { Funcionario } from 'src/app/models/funcionario.model';
import { AluguelService } from 'src/app/services/aluguel.services';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { ClienteService } from 'src/app/services/cliente.services';
import { RegistrarFilmeService } from 'src/app/services/registrar-filme.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-cliente-finalizar-aluguel',
  templateUrl: './cliente.finalizar-aluguel.component.html',
  styleUrls: ['./cliente.finalizar-aluguel.component.css']
})
export class ClienteFinalizarAluguelComponent implements OnInit {
  id: number;
  cliente: Cliente = new Cliente();
  valorTotalAluguel: number = 0.00;
  filmesSelecionados: Filme[] = [];
  filmesComErroNoProcessamento: Filme[] = [];
  tentativa: number = 1;
  mensagemRetorno: string = '';
  exibirMensagemRetorno: boolean = false;
  constructor(private _activatedRoute: ActivatedRoute,
              private _clienteService: ClienteService,
              private _aluguelService: AluguelService,
              private _authentication: AuthenticationService,
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
        this.getFilmesByLocalStorage();
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao buscar os dados do cliente!';
    });
  }

  finalizar() {
    if (this.tentativa === 1){
        this.processarPrimeiraTentativa();
    } else {
      this.processarFilmesComErro();
    }
  }

  private processarPrimeiraTentativa(){
    let processos: number = 1;
    let erros: boolean = false;
    this.filmesSelecionados.forEach((filme) => {
      let aluguel = new Aluguel();
      aluguel.set(this.cliente, filme, this._authentication.currentUserValue.data, filme.valor);
      timer(2000).subscribe(() => {
        this._aluguelService.create(aluguel).subscribe(() => { 
          this.retornoTodosProcessos(processos);
          processos++;
        },
        (err) => {
          console.log(err);
          erros = true;
          this.filmesComErroNoProcessamento.push(filme);
          this.tentativa++;
          this.retornoTodosProcessos(processos);
          processos++;
        });
      });
    });
  }

  private processarFilmesComErro(){
    let processos: number = 1;
    let erros: boolean = false;
    this.filmesComErroNoProcessamento.forEach((filme) => {
      let aluguel = new Aluguel();
      aluguel.set(this.cliente, filme, this._authentication.currentUserValue.data, filme.valor);
      timer(2000).subscribe(() => {
        this._aluguelService.create(aluguel).subscribe((ret) => { 
          let filmeOk = this.filmesComErroNoProcessamento.find(p => p.id == ret.data.filmeId);
          this.filmesComErroNoProcessamento.splice(this.filmesComErroNoProcessamento.indexOf(filmeOk), 1);
          this.retornoTodosProcessos(processos);
          processos++;
        },
        (err) => {
          console.log(err);
          erros = true;
          this.tentativa++;
          this.retornoTodosProcessos(processos);
          processos++;
        });
      });
    });
  }

  private retornoTodosProcessos(processos: number){
    if(processos == this.filmesSelecionados.length) {
      if(this.filmesComErroNoProcessamento.length > 0) {
        this.exibirMensagemRetorno = true;
        this.mensagemRetorno = 'Ocorreu um erro para processar alguns filmes, por favor, tente novamente!';
        this.tentativa++;
      } else {
        this._registrarFilmes.remove(this.cliente);
        this._router.navigate([`clientes/detalhes/${this.id}`]);
      }
    }
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
      this.getAluguelGratuito();
    }
  }

  private getAluguelGratuito(){
    this._aluguelService.getAluguelGratuito(this.cliente.id.toString()).subscribe((ret)=>{
      if(ret.data.possuiAluguelGratuito === true) {
        this.valorTotalAluguel -= this.filmesSelecionados[0].valor;
        this.filmesSelecionados[0].valor = 0;
      }
    },
    (err)=>{
      console.log(err);
    })
  }
}