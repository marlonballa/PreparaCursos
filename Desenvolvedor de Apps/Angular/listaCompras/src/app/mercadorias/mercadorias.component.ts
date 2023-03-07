import { Component,OnInit } from '@angular/core';
import { Mercadoria } from '../mercadoria';
import { MercadoriaService } from '../mercadoria.service';

@Component({
  selector: 'app-mercadorias',
  templateUrl: './mercadorias.component.html',
  styleUrls: ['./mercadorias.component.css']
})

export class MercadoriasComponent {
  title = "Lista de Compras";

  mercadorias!: Mercadoria[];
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

  constructor(private mercadoriaService: MercadoriaService) { }
  ngOnInit() {
    this.getMercadorias();
  }
  getMercadorias(): void {
    this.mercadorias = this.mercadoriaService.getMercadorias();
  }

  emConstrucao() {
    alert("Esta funcionalidade ainda está em construção!")
  }
}
