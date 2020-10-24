import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Cliente } from '../models/cliente.model';
import { Filme } from '../models/filme.model';
import { RegistroFilme } from '../models/registro-filme.model';

@Injectable({
  providedIn: 'root'
})
export class RegistrarFilmeService {
  
  registros: RegistroFilme[];
  KEY_REGISTROS: string = 'reg_filmes'
  constructor() { }

  public get(cliente: Cliente): Filme[]{
    if(cliente == undefined) {
      return null;
    }

    this.all();

    let registro = this.getRegistro(cliente);
    if(registro == undefined) {
      return null;
    }

    return registro.filmes;
  }

  public set(filmes: Filme[], cliente: Cliente){
    if(cliente == undefined) {
      return;
    }

    this.all();

    let registroFilmes: RegistroFilme = new RegistroFilme();
    registroFilmes.cliente = cliente;
    registroFilmes.filmes = filmes;

    this.removeRegistro(cliente);

    this.registros.push(registroFilmes);
    
    localStorage.setItem(this.KEY_REGISTROS, JSON.stringify(this.registros));
  }

  public remove(cliente: Cliente){
    if(cliente == undefined) {
      return null;
    }

    this.all();
    this.removeRegistro(cliente);    
  }

  private all() {
    let registros = new BehaviorSubject<RegistroFilme[]>(JSON.parse(localStorage.getItem(this.KEY_REGISTROS))).getValue();
    if (registros) {
      this.registros = registros;
    } else {
      this.registros = [];
    }
  }

  private removeRegistro(cliente: Cliente) {
    let registro = this.registros.find(c => c.cliente.id == cliente.id);
    if(registro == undefined) {
      return null;
    }
    this.registros.splice(this.registros.indexOf(registro, 1));
  }

  private getRegistro(cliente: Cliente){
    return this.registros.find(c => c.cliente.id == cliente.id);
  }

}