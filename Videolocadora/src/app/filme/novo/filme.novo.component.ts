import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Filme } from 'src/app/models/filme.model';
import { FilmeService } from 'src/app/services/filme.services';

@Component({
  selector: 'app-filme-novo',
  templateUrl: './filme.novo.component.html',
  styleUrls: ['./filme.novo.component.css']
})
export class FilmeNovoComponent {


  exibirMensagemRetorno: boolean = false;
  mensagemRetorno: string = '';

  filmeForm: FormGroup = this.formBulider.group({  
    titulo: ['', [Validators.required]],
    descricao: ['', [Validators.required]],  
    valor: ['', [Validators.required]],
    urlImagem: ['']
  });

  constructor(private formBulider : FormBuilder, private _filmeService: FilmeService) { }

  onSubmit(){
    this._filmeService.create(this.filmeForm.value).subscribe(() => {
      this.mensagemRetorno = 'Filme criado com sucesso!';
      this.exibirMensagemRetorno = true;
    },
    (err) => {
      console.log(err);
      this.mensagemRetorno = 'Ocorreu um erro ao criar o filme.';
      this.exibirMensagemRetorno = true;
    });
  }

}