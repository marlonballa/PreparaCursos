/**
 Este código importa as classes HttpClient e HttpHeaders do módulo HttpClientModule do Angular.

  O HttpClient é uma classe que permite fazer requisições HTTP para um servidor. Ele possui vários métodos como get, post, put e delete, que são usados para enviar requisições HTTP para o servidor.

  O HttpHeaders é uma classe que permite definir os cabeçalhos HTTP para as requisições enviadas pelo HttpClient. Cabeçalhos HTTP são informações adicionais enviadas junto com a requisição, como por exemplo o tipo de conteúdo que está sendo enviado ou informações de autenticação.

  Ao importar essas classes, estamos permitindo que a nossa aplicação Angular faça requisições HTTP para um servidor e envie informações adicionais através dos cabeçalhos HTTP.
 */
import { HttpClient, HttpHeaders } from '@angular/common/http';
/**
 A classe Injectable é um decorador que pode ser usado para fornecer metadados que permitem que o Angular injete uma dependência em um componente, diretiva ou outro serviço. Quando você define um serviço como injetável, o Angular cria uma única instância desse serviço e a disponibiliza para qualquer classe que dependa dela.

  Isso significa que, sempre que uma classe depende de um serviço injetável, o Angular procura por uma instância desse serviço na hierarquia de injeção de dependência e a disponibiliza para a classe que o solicita.

  Em resumo, o Injectable é um recurso que permite que as classes sejam injetáveis em outras classes, permitindo a criação de serviços reutilizáveis que podem ser usados em diferentes partes de um aplicativo Angular.
 */
import { Injectable } from '@angular/core';
/**
  Este código importa o Observable da biblioteca RxJS, que é uma das principais bibliotecas utilizadas no Angular para lidar com programação reativa e assíncrona.

  O Observable é uma classe que permite a criação de fluxos de dados assíncronos, que podem ser observados por diversos componentes da aplicação e reagir a mudanças nesse fluxo de dados. Ele é bastante utilizado para gerenciar a comunicação entre o backend e o frontend da aplicação, permitindo que os dados sejam obtidos e atualizados de forma assíncrona sem a necessidade de recarregar a página.
 */
import { Observable } from 'rxjs';
import { People } from './People';

// Define as opções do cabeçalho HTTP para todas as requisições
const httpOptions = {
  headers: new HttpHeaders({
    'content-type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class PeoplesService {
  // Define a URL base da API
  url = 'https://localhost:7270/api/peoples'

  constructor(private http: HttpClient) { }

  // Lista todas as pessoas
  ListAllPeople() : Observable<People[]> {
    return this.http.get<People[]>(this.url);
  }
  /**
    Este código é um método chamado ListAllPeople() que retorna um Observable do tipo People[], que é um array de objetos do tipo People. Esse método usa o serviço HttpClient fornecido pelo Angular para fazer uma requisição HTTP GET para a URL especificada por this.url, que é um endereço HTTP do servidor que fornece uma lista de objetos People.

    O método retorna o resultado da chamada HTTP GET como um Observable do tipo People[]. O operador get do serviço HttpClient faz uma solicitação GET para a URL especificada e retorna um Observable que emite a resposta como um objeto do tipo HttpResponse.

    Por ser um método assíncrono, o valor de retorno é encapsulado em um Observable, que permite a subscrição de outros métodos para o seu resultado e o uso do pipe com diversos operadores disponíveis no RxJS.
   */


  // Lista uma pessoa pelo seu ID
  ListPeopleBtId(peopleId: string) : Observable<People> {
    const apiUrl = `${this.url}/${peopleId}`
    return this.http.get<People>(apiUrl);
  }

  /**
    Este código representa um método chamado ListPeopleBtId que recebe um parâmetro peopleId do tipo string e retorna um objeto do tipo Observable<People>.

    Dentro do método, a constante apiUrl é criada concatenando a url da API e o peopleId recebido como parâmetro. Em seguida, a função get do objeto http é chamada, passando como argumento a apiUrl.

    O método retorna o resultado dessa chamada HTTP na forma de um objeto do tipo Observable<People>. Isso significa que a resposta da requisição é assíncrona e será entregue em um futuro próximo, e qualquer componente ou serviço que estiver usando esse método pode se inscrever para receber a resposta assim que ela estiver disponível.
   */

  // Salva uma nova pessoa
  SaveNewPeople(people : People) : Observable<any>{
    return this.http.post<People>(this.url, people, httpOptions);
  }
  /**
   Este código define um método chamado SaveNewPeople que recebe um objeto People como parâmetro e retorna um Observable do tipo any. O método utiliza o serviço http do Angular para enviar uma solicitação HTTP POST para uma determinada URL, que é definida pela propriedade url da classe PeoplesService. O segundo parâmetro do método http.post é o objeto people que foi recebido como parâmetro do método, que é enviado como corpo da solicitação POST. O terceiro parâmetro é um objeto que define as opções para a solicitação HTTP, incluindo o cabeçalho content-type definido como application/json. O método post retorna um Observable do tipo People, que é mapeado para o tipo any neste método.
   */

  // Atualiza os dados de uma pessoa existente
  UpdatePeople(people : People) : Observable<any> {
    return this.http.put<People>(this.url, people, httpOptions);
  }
  /**
    Este código define um método chamado UpdatePeople que recebe um objeto People e retorna um Observable<any>, que é uma representação assíncrona do resultado da atualização de um recurso no servidor. O método faz uma requisição HTTP PUT para a URL especificada em this.url, passando o objeto People como o corpo da requisição. As opções HTTP são definidas na constante httpOptions, que inclui o cabeçalho Content-Type definido como application/json. O método usa a classe HttpClient do Angular para fazer a requisição e retorna o Observable<any> que pode ser inscrito por um componente ou serviço para obter a resposta da API.
   */

  // Exclui uma pessoa pelo seu ID
  DeletePeople(peopleId : string) : Observable<any> {
    const apiUrl = `${this.url}/${peopleId}`;
    return this.http.delete<string>(apiUrl, httpOptions);
  }

  /**
    O código apresentado define um método chamado "DeletePeople" que utiliza o método HTTP DELETE do módulo HttpClient do Angular para excluir um recurso no servidor. Ele recebe como parâmetro um identificador (peopleId) que será concatenado com a URL base (this.url) para gerar a URL completa do recurso que deve ser excluído (apiUrl). Em seguida, o método retorna a chamada do método delete() do HttpClient passando a URL completa do recurso e o objeto httpOptions que contém o cabeçalho HTTP com o tipo de conteúdo JSON. Por fim, o método retorna um Observable que permite que outras partes da aplicação se inscrevam e recebam notificações quando a operação de exclusão é concluída.
   */
}

/**
 Neste código, criamos um serviço Angular PeoplesService que faz chamadas para uma API REST que gerencia informações sobre pessoas. As funcionalidades do serviço são:
    ListAllPeople(): lista todas as pessoas cadastradas na API.
    ListPeopleBtId(peopleId: string): busca uma pessoa pelo seu ID.
    SaveNewPeople(people: People): adiciona uma nova pessoa na API.
    UpdatePeople(people: People): atualiza os dados de uma pessoa existente na API.
    DeletePeople(peopleId: string): exclui uma pessoa da API pelo seu ID.
  Para realizar as chamadas HTTP para a API, utilizamos o HttpClient do Angular, que permite fazer requisições assíncronas. Além disso, definimos opções de cabeçalho HTTP através da constante httpOptions, que serão utilizadas em todas as chamadas HTTP realizadas pelo serviço.
 */

  /**
    O cabeçalho HTTP é uma seção da mensagem de solicitação ou resposta HTTP que contém informações adicionais sobre a transação HTTP em questão. Ele é composto de pares chave-valor e é usado para fornecer informações sobre a origem da solicitação ou resposta, o tipo de conteúdo que está sendo transferido, as configurações de cache, a autenticação e muito mais. O cabeçalho HTTP é importante porque ajuda a garantir que a comunicação entre o cliente e o servidor seja clara e precisa.
   */

  /**
    Este código é um método chamado ListAllPeople() que retorna um Observable do tipo People[], que é um array de objetos do tipo People. Esse método usa o serviço HttpClient fornecido pelo Angular para fazer uma requisição HTTP GET para a URL especificada por this.url, que é um endereço HTTP do servidor que fornece uma lista de objetos People.

    O método retorna o resultado da chamada HTTP GET como um Observable do tipo People[]. O operador get do serviço HttpClient faz uma solicitação GET para a URL especificada e retorna um Observable que emite a resposta como um objeto do tipo HttpResponse.

    Por ser um método assíncrono, o valor de retorno é encapsulado em um Observable, que permite a subscrição de outros métodos para o seu resultado e o uso do pipe com diversos operadores disponíveis no RxJS.
    */