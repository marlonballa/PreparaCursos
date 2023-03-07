import { Component } from '@angular/core';

@Component({
  selector: 'app-mercadorias',
  templateUrl: './mercadorias.component.html',
  styleUrls: ['./mercadorias.component.css']
})

export class MercadoriasComponent {
  title = "Lista de Compras";
  emConstrucao() {
    alert("Esta funcionalidade ainda está em construção!")
  }
  mercadorias = 
  [
    {
      id:1,
      descricao: "Arroz",
      quantidade: 1, 
      quantidadeMinima: 10
    }     
  ]

  newProduct = {
    id: 2,
    descricao: "Feijão",
    quantidade: 2,
    quantidadeMinima: 1
  }

  //Função responsável por adicionar novos produtos à lista de compras
  addNewProduct() {
    this.mercadorias.push({
      id:this.newProduct.id,
      descricao: this.newProduct.descricao,
      quantidade: this.newProduct.quantidade,
      quantidadeMinima: this.newProduct.quantidadeMinima
    });
  }
  constructor() { }
}
