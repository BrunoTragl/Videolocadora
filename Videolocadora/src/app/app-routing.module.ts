import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AluguelComponent } from './aluguel/aluguel.component';
import { ClienteBuscarComponent } from './cliente/buscar/cliente.buscar.component';
import { ClienteDetalhesComponent } from './cliente/detalhes/cliente.detalhes.component';
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

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'filmes/detalhes/:id', component: FilmeDetalheComponent },
  { path: 'filmes/novo', component: FilmeNovoComponent },
  { path: 'filmes/buscar', component: FilmeBuscarComponent },
  { path: 'funcionario/home', component: FuncionarioComponent },
  { path: 'funcionario/novo', component: FuncionarioNovoComponent },
  { path: 'funcionario/trocar-senha', component: FuncionarioTrocarSenhaComponent },
  { path: 'aluguel', component: AluguelComponent },
  { path: 'clientes/novo', component: ClienteNovoComponent },
  { path: 'clientes/buscar', component: ClienteBuscarComponent },
  { path: 'clientes/detalhes/:id', component: ClienteDetalhesComponent },
  { path: 'clientes/detalhes/registrar-filmes/:id', component: ClienteRegistrarFilmesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
