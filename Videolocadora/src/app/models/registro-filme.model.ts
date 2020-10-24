import { Cliente } from './cliente.model';
import { Filme } from './filme.model';

export class RegistroFilme {
    
    public filmes: Filme[];
    public cliente: Cliente;
    
    constructor() { }
}