import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AluguelComponent } from './aluguel/aluguel.component';
import { ClienteBuscarComponent } from './cliente/buscar/cliente.buscar.component';
import { ClienteComponent } from './cliente/home/cliente.component';
import { ClienteNovoComponent } from './cliente/novo/cliente.novo.component';
import { FilmeAlugadoComponent } from './filme/alugado/filme.alugado.component';
import { FilmeBuscarComponent } from './filme/buscar/filme.buscar.component';
import { FilmeComponent } from './filme/home/filme.component';
import { FilmeNovoComponent } from './filme/novo/filme.novo.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'filmes', component: FilmeComponent },
  { path: 'filmes/novo', component: FilmeNovoComponent },
  { path: 'filmes/buscar', component: FilmeBuscarComponent },
  { path: 'filmes/alugados', component: FilmeAlugadoComponent },
  { path: 'funcionario/home', component: FuncionarioComponent },
  { path: 'funcionario/novo', component: FuncionarioComponent },
  { path: 'aluguel', component: AluguelComponent },
  { path: 'clientes', component: ClienteComponent },
  { path: 'clientes/novo', component: ClienteNovoComponent },
  { path: 'clientes/buscar', component: ClienteBuscarComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
