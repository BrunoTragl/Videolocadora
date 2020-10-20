
export class ApiUrl {
    
    public funcionario: string;
    public login: string;
    public filme: string;
    public aluguel: string;
    public cliente: string;

    constructor(){
        let base = 'https://localhost:44306/api/';
        this.funcionario = `${base}funcionario`;
        this.login = `${base}funcionario/login`;
        this.filme = `${base}filme`;
        this.aluguel = `${base}aluguel`;
        this.cliente = `${base}cliente`;
    }
}