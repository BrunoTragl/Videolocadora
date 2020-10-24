import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Data } from 'src/app/models/data.model';
import { Filme } from 'src/app/models/filme.model';
import { FilmeService } from 'src/app/services/filme.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-filme-buscar',
  templateUrl: './filme.buscar.component.html',
  styleUrls: ['./filme.buscar.component.css']
})
export class FilmeBuscarComponent implements OnInit {

  public filmes: Filme[] = [];

  public buscarFilmeForm: FormGroup = this._formBulider.group({  
    titulo: ['', [Validators.required]]
  });

  public exibirMensagemRetorno: boolean = false;
  public mensagemRetorno: string = '';
  private _initialSkip: number = 0;
  private _initialTake: number = 8;
  private skip: number;
  private take: number;
  public showMoreFilmes: boolean = false;
  constructor(private _router: Router, 
              private _formBulider: FormBuilder,
              private _filmeService: FilmeService,
              public _tratamentoDados: TratamentoDadosService) { }

  ngOnInit() {
    this.initialFilmes();  
  }

  enterFilme(id: number){
    this._router.navigate([`filmes/detalhes/${id}`]);
  }

  initialFilmes(){
    this.configSearch();
    this._filmeService.getPagination(' ', this.skip, this.take).subscribe((ret) => {
      this.pushFilmes(ret);
    },
    (err) => {
      this.error(err);
    });
  }

  seachFilmes(){
    this.configSearch();
    let titulo: string = ' ';
    if(this.buscarFilmeForm.value.titulo !== ''){
      titulo = this.buscarFilmeForm.value.titulo;
    }
    this._filmeService.getPagination(titulo, this.skip, this.take).subscribe((ret) => {
      if(ret.data.length === 0){
        this.exibirMensagemRetorno = true;
        this.mensagemRetorno = 'Não houve resultados para esta palavra-chave.';
      }
      else {
        this.pushFilmes(ret);
      }
    },
    (err) => {
      this.error(err);
    });
  }

  moreFilmes(){
    let titulo: string = ' ';
    if(this.buscarFilmeForm.value.titulo !== ''){
      titulo = this.buscarFilmeForm.value.titulo;
    }
    this.clearMessageError();
    this.skip += this.take;
    this._filmeService.getPagination(titulo, this.skip, this.take).subscribe((ret) => {
      this.pushFilmes(ret);
    },
    (err) => {
      this.error(err);
    });
  }

  private pushFilmes(ret: Data<Filme[]>){
    this.showMoreFilmes = ret.data.length == this.take;
    ret.data.forEach((filme) => {
      this.filmes.push(filme);
    },
    (err) => {
      this.error(err);
    });
  }

  private error(err: any){
    console.log(err);
    this.exibirMensagemRetorno = true;
    this.mensagemRetorno = "Ocorreu um erro ao buscar filmes!"
    this.showMoreFilmes = false;
  }

  private configSearch(){
    this.filmes = [];
    this.skip = this._initialSkip;
    this.take = this._initialTake;
    this.showMoreFilmes = false;
    this.clearMessageError();
  }

  private clearMessageError(){
    this.exibirMensagemRetorno = false;
    this.mensagemRetorno = ""
  }
}