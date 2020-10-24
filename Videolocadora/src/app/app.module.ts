import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { FuncionarioNovoComponent } from './funcionario/novo/funcionario.novo.component';
import { AluguelComponent } from './aluguel/aluguel.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ClienteDetalhesComponent } from './cliente/detalhes/cliente.detalhes.component';
import { ClienteNovoComponent } from './cliente/novo/cliente.novo.component';
import { ClienteBuscarComponent } from './cliente/buscar/cliente.buscar.component';
import { FilmeNovoComponent } from './filme/novo/filme.novo.component';
import { FilmeBuscarComponent } from './filme/buscar/filme.buscar.component';
import { HomeComponent } from './home/home.component';
import { FuncionarioService } from './services/funcionario.services';
import { HttpClientModule } from '@angular/common/http';
import { AuthenticationService } from './services/authentication.service';
import { NavComponent } from './components/nav/nav.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { TratamentoDadosService } from './services/tratamento.dados.services';
import { FuncionarioTrocarSenhaComponent } from './funcionario/trocar-senha/funcionario.trocar-senha.component';
import { FilmeService } from './services/filme.services';
import { ApiUrlService } from './services/api-url.service';
import { FilmeDetalheComponent } from './filme/detalhe/filme.detalhe.component';
import { AngularResizedEventModule } from 'angular-resize-event';
import { ClienteService } from './services/cliente.services';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { FilmeExibirComponent } from './filme/exibir-filmes/filme.exibir-para-aluguel.component';
import { ClienteRegistrarFilmesComponent } from './cliente/registrar-filme/cliente.registrar-filmes.component';

const maskConfigFunction: () => Partial<IConfig> = () => {
  return {
    validation: false,
  };
};

@NgModule({
  declarations: [
    AppComponent,
    FilmeDetalheComponent,
    FilmeNovoComponent,
    FilmeBuscarComponent,
    FuncionarioComponent,
    AluguelComponent,
    ClienteDetalhesComponent,
    ClienteNovoComponent,
    ClienteBuscarComponent,
    HomeComponent,
    LoginComponent,
    NavComponent,
    FuncionarioNovoComponent,
    FuncionarioTrocarSenhaComponent,
    FilmeExibirComponent,
    ClienteRegistrarFilmesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModalModule.forRoot(),
    HttpClientModule,
    ReactiveFormsModule,
    AngularResizedEventModule,
    FormsModule,
    NgxMaskModule.forRoot(maskConfigFunction)
  ],
  exports: [],
  providers: [
    FuncionarioService, 
    AuthenticationService, 
    TratamentoDadosService,
    FilmeService,
    ClienteService,
    ApiUrlService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  
}
