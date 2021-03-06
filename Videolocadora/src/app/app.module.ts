import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { FuncionarioNovoComponent } from './funcionario/novo/funcionario.novo.component';
import { RegistroAluguelComponent } from './aluguel/registro-aluguel/aluguel.registro-aluguel.component';
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
import { RegistrarFilmeService } from './services/registrar-filme.services';
import { ClienteFinalizarAluguelComponent } from './cliente/finalizar-aluguel/cliente.finalizar-aluguel.component';
import { AluguelService } from './services/aluguel.services';
import { RelatorioAlugueisAtivosComponent } from './relatorio/alugueis-ativos/relatorio.alugueis-ativos.component';
import { RelatorioClientesInadimplentesComponent } from './relatorio/clientes-inadimplentes/relatorio.clientes-inadimplentes.component';
import { RelatorioService } from './services/relatorio.services';

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
    RegistroAluguelComponent,
    ClienteDetalhesComponent,
    ClienteNovoComponent,
    ClienteBuscarComponent,
    HomeComponent,
    LoginComponent,
    NavComponent,
    FuncionarioNovoComponent,
    FuncionarioTrocarSenhaComponent,
    FilmeExibirComponent,
    ClienteRegistrarFilmesComponent,
    ClienteFinalizarAluguelComponent,
    RelatorioAlugueisAtivosComponent,
    RelatorioClientesInadimplentesComponent
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
    ApiUrlService,
    RegistrarFilmeService,
    AluguelService,
    RelatorioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  
}
