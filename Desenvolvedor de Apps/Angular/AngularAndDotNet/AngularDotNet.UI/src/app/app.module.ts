import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

import { PeoplesService } from './peoples.service';

/**
 O módulo CommomModule do Angular exporta diretivas, pipes e outros componentes comuns utilizados em muitos módulos diferentes, como NgIf, NgFor, DatePipe, etc. Ele também fornece serviços comuns, como HttpClient e HttpHeaders, além de diretivas como FormsModule e ReactiveFormsModule para trabalhar com formulários.
 */
import { CommonModule } from '@angular/common';

/**
 O módulo HttpClientModule do Angular fornece um serviço HttpClient para fazer requisições HTTP e obter dados de APIs RESTful. Ele simplifica as operações HTTP, oferecendo métodos para realizar as operações GET, POST, PUT, DELETE, entre outras. Além disso, ele também fornece suporte para interceptores de requisição e resposta, permitindo que você possa adicionar ou modificar cabeçalhos e tokens de autenticação, por exemplo.
 */
import { HttpClientModule } from '@angular/common/http';
/**
 O módulo ReactiveFormsModule do Angular fornece suporte para trabalhar com formulários reativos, permitindo que você crie formulários com validação avançada e manipule facilmente o estado do formulário. Ele oferece uma maneira programática de gerenciar e reagir a mudanças nos valores dos campos do formulário, permitindo uma validação mais complexa e um melhor controle sobre o estado dos formulários. Além disso, ele também oferece suporte para validação assíncrona e personalizada.
 */
import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from "ngx-bootstrap/modal"


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, 
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],

  //Em providers registramos o que vamos inicializar via injeção de dependências
  providers: [HttpClientModule, PeoplesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
