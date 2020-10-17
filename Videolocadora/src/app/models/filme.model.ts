export class Filme {
    
    public id: number;
    public titulo: string;
    public descricao: string;

    constructor(id: number, titulo: string, descricao: string){
        this.id = id;
        this.titulo = titulo;
        this.descricao = descricao;
    }
}