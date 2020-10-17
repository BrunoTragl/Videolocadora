import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AluguelComponent } from './components/aluguel/aluguel.component';
import { ClienteBuscarComponent } from './components/cliente/buscar/cliente.buscar.component';
import { ClienteComponent } from './components/cliente/home/cliente.component';
import { ClienteNovoComponent } from './components/cliente/novo/cliente.novo.component';
import { FilmeAlugadoComponent } from './components/filme/alugado/filme.alugado.component';
import { FilmeBuscarComponent } from './components/filme/buscar/filme.buscar.component';
import { FilmeComponent } from './components/filme/home/filme.component';
import { FilmeNovoComponent } from './components/filme/novo/filme.novo.component';
import { FuncionarioComponent } from './components/funcionario/funcionario.component';
import { LoginComponent } from './components/login/authentication/login.component';
import { LoginCadastroComponent } from './components/login/cadastro/login.cadastro.component';
import { LoginEsqueciMinhaSenhaComponent } from './components/login/esqueci_minha_senha/login.esqueci.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'login/cadastro', component: LoginCadastroComponent },
  { path: 'login/esqueci', component: LoginEsqueciMinhaSenhaComponent },
  { path: 'filmes', component: FilmeComponent },
  { path: 'filmes/novo', component: FilmeNovoComponent },
  { path: 'filmes/buscar', component: FilmeBuscarComponent },
  { path: 'filmes/alugados', component: FilmeAlugadoComponent },
  { path: 'funcionario', component: FuncionarioComponent },
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
