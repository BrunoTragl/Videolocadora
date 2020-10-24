
import { Component, OnInit } from '@angular/core';
import { FuncionarioService } from 'src/app/services/funcionario.services';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';  
import { Funcionario } from 'src/app/models/funcionario.model';

@Component({
  selector: 'app-funcionario-novo',
  templateUrl: './funcionario.novo.component.html',
  styleUrls: ['./funcionario.novo.component.css']
})
export class FuncionarioNovoComponent implements OnInit {

  exibirMensagemRetorno: boolean = false;
  mensagemRetorno: string = '';

  funcionarioForm: FormGroup = this.formBulider.group({  
    login: ['', [Validators.required]],
    nome: ['', [Validators.required]],  
    sobrenome: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    senha: ['', [Validators.required]],
    confirmaSenha: ['', [Validators.required]]
  });

  constructor(private formBulider: FormBuilder, private _funcionarioService: FuncionarioService) { }
  
  
  ngOnInit(): void {
    
  }

  onSubmit(){
    if(this.funcionarioForm.value.senha < 6) {
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'A senha deve conter mais de 6 caracteres.';
      return;
    }

    this._funcionarioService.create(this.funcionarioForm.value).subscribe(() => {
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Funcionário criado com sucesso!';
    },
    (err) => {
      console.log(err);
      this.exibirMensagemRetorno = true;
      this.mensagemRetorno = 'Ocorreu um erro ao criar o novo funcionário!';
    })
  }
}