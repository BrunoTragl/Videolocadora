import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FilmeComponent } from './components/filme/home/filme.component';
import { LoginComponent } from './components/login/authentication/login.component';
import { FuncionarioComponent } from './components/funcionario/funcionario.component';
import { AluguelComponent } from './components/aluguel/aluguel.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ClienteComponent } from './components/cliente/home/cliente.component';
import { ClienteNovoComponent } from './components/cliente/novo/cliente.novo.component';
import { ClienteBuscarComponent } from './components/cliente/buscar/cliente.buscar.component';
import { FilmeNovoComponent } from './components/filme/novo/filme.novo.component';
import { FilmeBuscarComponent } from './components/filme/buscar/filme.buscar.component';
import { FilmeAlugadoComponent } from './components/filme/alugado/filme.alugado.component';
import { LoginCadastroComponent } from './components/login/cadastro/login.cadastro.component';
import { LoginEsqueciMinhaSenhaComponent } from './components/login/esqueci_minha_senha/login.esqueci.component';

@NgModule({
  declarations: [
    AppComponent,
    FilmeComponent,
    FilmeNovoComponent,
    FilmeBuscarComponent,
    FilmeAlugadoComponent,
    LoginComponent,
    LoginCadastroComponent,
    LoginEsqueciMinhaSenhaComponent,
    FuncionarioComponent,
    AluguelComponent,
    ClienteComponent,
    ClienteNovoComponent,
    ClienteBuscarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
