import { Component, OnInit } from '@angular/core';
import { Aluguel } from 'src/app/models/aluguel.model';
import { RelatorioService } from 'src/app/services/relatorio.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-relatorio-clientes-inadimplentes',
  templateUrl: './relatorio.clientes-inadimplentes.component.html',
  styleUrls: ['./relatorio.clientes-inadimplentes.component.css']
})
export class RelatorioClientesInadimplentesComponent implements OnInit {
  alugueisAtivos: Aluguel[] = [];

  constructor(private _relatorioService: RelatorioService,
    private _tratamentoDados: TratamentoDadosService) { }

  ngOnInit() {
    this._relatorioService.getClientesInadimplentes().subscribe((ret) => {
      this.alugueisAtivos = ret.data;
    },
      (err) => {
        console.log(err);
      })
  }

}




