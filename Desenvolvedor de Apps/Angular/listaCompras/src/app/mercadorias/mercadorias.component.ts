import { Component } from '@angular/core';

@Component({
  selector: 'app-mercadorias',
  templateUrl: './mercadorias.component.html',
  styleUrls: ['./mercadorias.component.css']
})
export class MercadoriasComponent {
  title = "Lista de Compras";
  mercadorias = 
  [
    {
      id:1,
      descricao: "Arroz",
      quantidade: 1, 
      quantidadeMinima: 10
    },
    {
      id:2,
      descricao: "Feijão",
      quantidade: 5,
      quantidadeMinima: 30
    },
    {
      id:3,
      descricao: "Rúcula",
      quantidade: 60, 
      quantidadeMinima: 10
    },
    {
      id:4,
      descricao: "Paçoca",
      quantidade: 17,
      quantidadeMinima: 50
    },
    {
      id:5,
      descricao: "Geleia de Mocotó",
      quantidade: 100,
      quantidadeMinima: 25
    },                  
  ]
}
