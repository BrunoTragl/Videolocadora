
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { FuncionarioService } from 'src/app/services/funcionario.services';

@Component({
  selector: 'app-funcionario-trocar-senha',
  templateUrl: './funcionario.trocar-senha.component.html',
  styleUrls: ['./funcionario.trocar-senha.component.css']
})
export class FuncionarioTrocarSenhaComponent implements OnInit {

  constructor(private _formBulider: FormBuilder, 
              private _funcionarioService: FuncionarioService,
              private _authenticationService: AuthenticationService) { }

  public trocaSenhaForm: FormGroup;
  mensagemRetorno: string = '';
  exibirMensagemRetorno: boolean = false;

  ngOnInit() {
    this.trocaSenhaForm = this._formBulider.group({  
      senhaAtual: ['', [Validators.required]],
      novaSenha: ['', [Validators.required]],  
      confirmaSenha: ['', [Validators.required]]
    });    
  }

  onSubmit(){
    if(this.trocaSenhaForm.value.novaSenha.length < 6){
      this.mensagemRetorno = 'A senha deve conter no mínimo 6 caracteres.';
      this.exibirMensagemRetorno = true;
      return;

    } else if (this.trocaSenhaForm.value.novaSenha !== this.trocaSenhaForm.value.confirmaSenha){
      this.mensagemRetorno = 'Os campos nova senha e confirma senha devem ser iguais!';
      this.exibirMensagemRetorno = true;
      return;
      
    } else {
      let funcionarioId = this._authenticationService.currentUserValue.data.id;
      this._funcionarioService.changePassword(funcionarioId.toString(), this.trocaSenhaForm.value.novaSenha).subscribe(()=>{
        this.mensagemRetorno = 'Senha alterada com sucesso!';
        this.exibirMensagemRetorno = true;
      },
      (err)=>{
        console.log(err);
        this.mensagemRetorno = 'Ocorreu um erro ao trocar a senha.';
        this.exibirMensagemRetorno = true;
      });
    }
  }

}