import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistroAluguelComponent } from './aluguel/registro-aluguel/aluguel.registro-aluguel.component';
import { ClienteBuscarComponent } from './cliente/buscar/cliente.buscar.component';
import { ClienteDetalhesComponent } from './cliente/detalhes/cliente.detalhes.component';
import { ClienteFinalizarAluguelComponent } from './cliente/finalizar-aluguel/cliente.finalizar-aluguel.component';
import { ClienteNovoComponent } from './cliente/novo/cliente.novo.component';
import { ClienteRegistrarFilmesComponent } from './cliente/registrar-filme/cliente.registrar-filmes.component';
import { FilmeBuscarComponent } from './filme/buscar/filme.buscar.component';
import { FilmeDetalheComponent } from './filme/detalhe/filme.detalhe.component';
import { FilmeNovoComponent } from './filme/novo/filme.novo.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { FuncionarioNovoComponent } from './funcionario/novo/funcionario.novo.component';
import { FuncionarioTrocarSenhaComponent } from './funcionario/trocar-senha/funcionario.trocar-senha.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RelatorioAlugueisAtivosComponent } from './relatorio/alugueis-ativos/relatorio.alugueis-ativos.component';
import { RelatorioClientesInadimplentesComponent } from './relatorio/clientes-inadimplentes/relatorio.clientes-inadimplentes.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'filmes/detalhes/:id', component: FilmeDetalheComponent },
  { path: 'filmes/novo', component: FilmeNovoComponent },
  { path: 'filmes/buscar', component: FilmeBuscarComponent },
  { path: 'funcionario/home', component: FuncionarioComponent },
  { path: 'funcionario/novo', component: FuncionarioNovoComponent },
  { path: 'funcionario/trocar-senha', component: FuncionarioTrocarSenhaComponent },
  { path: 'clientes/novo', component: ClienteNovoComponent },
  { path: 'clientes/buscar', component: ClienteBuscarComponent },
  { path: 'clientes/detalhes/:id', component: ClienteDetalhesComponent },
  { path: 'clientes/registrar-filmes/:id', component: ClienteRegistrarFilmesComponent },
  { path: 'clientes/finalizar/:id', component: ClienteFinalizarAluguelComponent },
  { path: 'aluguel/registro/:id', component: RegistroAluguelComponent },
  { path: 'relatorio/alugueis-ativos', component: RelatorioAlugueisAtivosComponent },
  { path: 'relatorio/clientes-inadimplentes', component: RelatorioClientesInadimplentesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
