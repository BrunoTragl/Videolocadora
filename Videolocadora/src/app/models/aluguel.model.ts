import { Cliente } from './cliente.model';
import { Filme } from './filme.model';
import { Funcionario } from './funcionario.model';

export class Aluguel {
    
    public id: number;
    public valorPago: number;
    public multa: number;
    public devolucao: Date;
    public devolveu: Date;
    public cliente: Cliente;
    public clienteId: number;
    public funcionario: Funcionario;
    public funcionarioId: number;
    public filme: Filme;
    public filmeId: number;
    public cadastro: Date;
    public ativo: boolean;
    
    constructor() { }

    public set(cliente: Cliente, filme: Filme, funcionario: Funcionario, valorPago: number){
        this.cliente = cliente;
        this.clienteId = cliente.id;
        this.filme = filme;
        this.filmeId = filme.id;
        this.funcionario = funcionario;
        this.funcionarioId = funcionario.id;
        this.valorPago = valorPago;
    }
}