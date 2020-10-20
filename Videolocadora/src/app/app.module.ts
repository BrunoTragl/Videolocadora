import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FilmeComponent } from './filme/home/filme.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { FuncionarioNovoComponent } from './funcionario/novo/funcionario.novo.component';
import { AluguelComponent } from './aluguel/aluguel.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ClienteComponent } from './cliente/home/cliente.component';
import { ClienteNovoComponent } from './cliente/novo/cliente.novo.component';
import { ClienteBuscarComponent } from './cliente/buscar/cliente.buscar.component';
import { FilmeNovoComponent } from './filme/novo/filme.novo.component';
import { FilmeBuscarComponent } from './filme/buscar/filme.buscar.component';
import { FilmeAlugadoComponent } from './filme/alugado/filme.alugado.component';
import { HomeComponent } from './home/home.component';
import { FuncionarioService } from './services/funcionario.services';
import { HttpClientModule } from '@angular/common/http';
import { AuthenticationService } from './services/authentication.service';
import { NavComponent } from './components/nav/nav.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    FilmeComponent,
    FilmeNovoComponent,
    FilmeBuscarComponent,
    FilmeAlugadoComponent,
    FuncionarioComponent,
    AluguelComponent,
    ClienteComponent,
    ClienteNovoComponent,
    ClienteBuscarComponent,
    HomeComponent,
    LoginComponent,
    NavComponent,
    FuncionarioNovoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModalModule.forRoot(),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [],
  providers: [FuncionarioService, AuthenticationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
