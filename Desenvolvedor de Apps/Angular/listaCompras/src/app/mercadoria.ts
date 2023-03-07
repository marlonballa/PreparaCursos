export class Mercadoria {
    id: number;
    descricao: string;
    quantidade: number;
    quantidadeMinima: number;

    constructor (id:number, descricao:string, quantidade:number, quantidadeMinima:number) {
        this.id = id;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.quantidadeMinima = quantidadeMinima;
    }
}