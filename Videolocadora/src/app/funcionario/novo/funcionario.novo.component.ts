
import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.services';
import { FormBuilder, Validators } from '@angular/forms';  
import { Funcionario } from 'src/app/models/funcionario.model';
import { Data } from 'src/app/models/data.model';;

@Component({
  selector: 'app-funcionario-novo',
  templateUrl: './funcionario.novo.component.html',
  styleUrls: ['./funcionario.novo.component.css']
})
export class FuncionarioNovoComponent implements OnInit {

  funcionarioForm: any;
  funcionario: Data<Funcionario>;
  constructor(private formBulider: FormBuilder, private _funcionarioService: FuncionarioService) { }

  ngOnInit() {
    this.funcionarioForm = this.formBulider.group({  
      Nome: ['', [Validators.required]],  
      Sobrenome: ['', [Validators.required]]
    });

    this.getFuncionario();
  }

  getFuncionario(){
    this._funcionarioService.getFuncionarioById("1").subscribe(observableFuncionario => {
      this.funcionario = observableFuncionario;
    });
    
  }
}