import { Component } from '@angular/core';

@Component({
  selector: 'app-mercadorias',
  templateUrl: './mercadorias.component.html',
  styleUrls: ['./mercadorias.component.css']
})

export class MercadoriasComponent {
  title = "Lista de Compras";
  // classes = {

  // }
  // addNewProduct() {
  //   let modalContainer = document.querySelector('#modalContainer');
  //   modalContainer.classList.remove('desabilitada');
  //   modalContainer.classList.add("habilitada");
  // }  
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

  constructor() { }
}
