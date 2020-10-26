import { Component, OnInit } from '@angular/core';
import { Aluguel } from 'src/app/models/aluguel.model';
import { RelatorioService } from 'src/app/services/relatorio.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-relatorio-alugueis-ativos',
  templateUrl: './relatorio.alugueis-ativos.component.html',
  styleUrls: ['./relatorio.alugueis-ativos.component.css']
})
export class RelatorioAlugueisAtivosComponent implements OnInit {
  alugueisAtivos: Aluguel[] = [];

  constructor(private _relatorioService: RelatorioService, 
              private _tratamentoDados: TratamentoDadosService) { }

  ngOnInit() {
    this._relatorioService.getAlugueisAtivos().subscribe((ret)=>{
      this.alugueisAtivos = ret.data;
    },
    (err)=>{
      console.log(err);
    })
  }

  
}




