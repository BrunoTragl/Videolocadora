import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Filme } from 'src/app/models/filme.model';
import { FilmeService } from 'src/app/services/filme.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-filme-detalhe',
  templateUrl: './filme.detalhe.component.html',
  styleUrls: ['./filme.detalhe.component.css']
})
export class FilmeDetalheComponent implements OnInit {

  id: number;
  filmeForm: FormGroup = this._formBulider.group({
    titulo: ['', [Validators.required]],
    descricao: ['', [Validators.required]],
    valor: [0, [Validators.required]],
    urlImagem: ['']
  });;
  mensagemRetorno: string = '';
  exibirMensagemRetorno: boolean = false;

  constructor(private _activatedRoute: ActivatedRoute,
              private _filmeService: FilmeService,
              private _formBulider: FormBuilder,
              public _tratamentoDados: TratamentoDadosService) {
    this.id = _activatedRoute.snapshot.params.id;
  }

  ngOnInit() {
    this.getFilme();
  }

  private getFilme() {

    this._filmeService.getById(this.id.toString()).subscribe((ret) => {
      this.filmeForm = this._formBulider.group({
        titulo: [ret.data.titulo, [Validators.required]],
        descricao: [ret.data.descricao, [Validators.required]],
        valor: [ret.data.valor, [Validators.required]],
        urlImagem: [ret.data.urlImagem]
      });
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao buscar os dados do filme!';
    });
  }

  onSubmit() {
    this._filmeService.edit(this.id.toString(), this.filmeForm.value).subscribe(() => {
      this.mensagemRetorno = 'Alterações salvo com sucesso!';
      this.exibirMensagemRetorno = true;
    },
      (err) => {
        console.log(err);
        this.mensagemRetorno = 'Ocorreu um erro ao salvar os dados do filme.';
        this.exibirMensagemRetorno = true;
      });
  }

}