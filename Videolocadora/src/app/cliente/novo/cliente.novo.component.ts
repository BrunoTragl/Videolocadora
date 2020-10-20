import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.services';
import { Observable } from 'rxjs';
import { Funcionario } from 'src/app/models/funcionario.model';
import { Data } from 'src/app/models/data.model';


@Component({
  selector: 'app-cliente-novo',
  templateUrl: './cliente.novo.component.html',
  styleUrls: ['./cliente.novo.component.css']
})
export class ClienteNovoComponent implements OnInit {

  funcionarioForm: any;
  funcionario: Data<Funcionario>;
  teste: any;
  constructor(private funcionarioService: FuncionarioService) { }

  ngOnInit() {
    this.getFuncionarioCredencial();
  }

  getFuncionario(){
    this.funcionarioService.getFuncionarioById("1").subscribe((func : Data<Funcionario>) => {
      this.funcionario = func;
    });    
  }

  getFuncionarioCredencial(){
    this.funcionarioService.getFuncionarioByCredencial("teste", "teste").subscribe((func : any) => {
      this.funcionario = func;
    });
  }

}