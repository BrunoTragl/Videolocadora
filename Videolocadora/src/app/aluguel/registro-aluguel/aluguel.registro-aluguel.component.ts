import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Aluguel } from 'src/app/models/aluguel.model';
import { AluguelService } from 'src/app/services/aluguel.services';
import { TratamentoDadosService } from 'src/app/services/tratamento.dados.services';

@Component({
  selector: 'app-registro-aluguel',
  templateUrl: './aluguel.registro-aluguel.component.html',
  styleUrls: ['./aluguel.registro-aluguel.component.css']
})
export class RegistroAluguelComponent implements OnInit {

  aluguel: Aluguel;
  id: number;
  valorMulta: number = 0;
  mensagemRetorno: string = '';
  exibirMensagemRetorno: boolean = false;
  constructor(private _activatedRoute: ActivatedRoute,
              private _aluguelService: AluguelService,
              public _tratamentoDados: TratamentoDadosService,
              private _router: Router) 
  { 
    this.id = _activatedRoute.snapshot.params.id;
  }

  ngOnInit() { 
    this.getAluguel()
    this.getMulta();
  }

  getAluguel(){
    this._aluguelService.getById(this.id.toString()).subscribe((ret)=>{
      this.aluguel = ret.data;
    },
    (err)=>{
      console.log(err);
    });
  }

  getMulta(){
    this._aluguelService.getMulta(this.id.toString()).subscribe((ret)=>{
      this.valorMulta = ret.data.multa;
    },
    (err)=>{
      console.log(err);
    })
  }

  aluguelAtrasado(aluguel: Aluguel): boolean {
    let devolucao = new Date(aluguel.devolucao);
    let today = new Date();
    if (devolucao instanceof Date && today > devolucao) {
      let diff = Math.abs(today.getTime() - devolucao.getTime());
      let diffDays = Math.ceil(diff / (1000 * 3600 * 24));
      return (diffDays - 1) > 0;
    }
    return false;
  }

  diasEmAtraso(aluguel: Aluguel): string {
    let devolucao = new Date(aluguel.devolucao);
    let diff = Math.abs(new Date().getTime() - devolucao.getTime());
    let diffDays = Math.ceil(diff / (1000 * 3600 * 24));
    return (diffDays - 1).toString();
  }

  voltar(){
    this._router.navigate([`clientes/detalhes/${this.aluguel.clienteId}`]);
  }

  devolver(){
    this.aluguel.devolveu = new Date();
    this.aluguel.multa = this.valorMulta;
    this.aluguel.valorPago += this.valorMulta;
    this._aluguelService.edit(this.aluguel.id, this.aluguel).subscribe((ret)=>{
      this.voltar();      
    },
    (err)=>{
      console.log(err);
      this.mensagemRetorno = 'Ocorreu um erro ao concluir a devolução do filme. Tente novamente.';
      this.exibirMensagemRetorno = true;
    });
  }
}