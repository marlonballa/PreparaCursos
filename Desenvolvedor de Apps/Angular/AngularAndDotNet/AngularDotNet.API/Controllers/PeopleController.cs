/*
    O código é um controlador de API RESTful em .NET Core que manipula operações de CRUD (Create, Read, Update, Delete) para a entidade "People" usando o Entity Framework Core.
        
    No geral, este código cria um endpoint de API RESTful para operações CRUD na entidade "People" usando o Entity Framework Core. Ele usa o padrão de injeção de dependência para passar um contexto do banco de dados para o controlador, e em seguida, define métodos HTTP para executar as operações CRUD.
*/
using AngularDotNet.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularDotNet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        // Declaração de um objeto de contexto do banco de dados que gerencia a entidade People
        private readonly PeopleContext _peopleContext;

        // Construtor que injeta o contexto do banco de dados no controlador
        public PeopleController(PeopleContext peopleContext)
        {
            _peopleContext = peopleContext;
        }

        //O método ListPeopleAsync usa uma operação de leitura do Entity Framework Core para retornar uma lista de todas as pessoas no banco de dados.
        // Método que lista todas as pessoas no banco de dados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<People>>> ListPeopleAsync() {
            return await _peopleContext.Peoples.ToListAsync();
        }

        //O método ListPeopleById usa uma operação de leitura para retornar uma pessoa específica com base em um ID fornecido. Se a pessoa não for encontrada, o método retorna um código de resposta 404 (Not Found).
        // Método que lista uma pessoa específica no banco de dados com base no ID fornecido
        [HttpGet("{peopleId}")]
        public async Task<ActionResult<People>> ListPeopleById(Guid peopleId){
            // Procura no banco de dados uma pessoa com o ID fornecido
            People people = await _peopleContext.Peoples.FindAsync(peopleId);

            // Se a pessoa não for encontrada, retorna um código de resposta 404 (Not Found)
            if(people == null){
                return NotFound();
            }

            // Se a pessoa for encontrada, retorna a pessoa como resultado
            return people;
        }

        //O método SaveNewPeopleAsync usa uma operação de escrita do Entity Framework Core para adicionar uma nova pessoa ao banco de dados.
        // Método que adiciona uma nova pessoa ao banco de dados
        [HttpPost]
        public async Task<ActionResult<People>> SaveNewPeopleAsync(People people) {
            // Adiciona a nova pessoa ao contexto do banco de dados
            await _peopleContext.Peoples.AddAsync(people);
            // Salva as alterações no banco de dados
            await _peopleContext.SaveChangesAsync(); 

            // Retorna um código de resposta 200 (OK) para indicar que a operação foi concluída com sucesso
            return Ok(); 
        }

        //O método UpdatePeopleAsync usa uma operação de escrita para atualizar uma pessoa existente no banco de dados.
        // Método que atualiza uma pessoa existente no banco de dados
        [HttpPut]
        public async Task<ActionResult> UpdatePeopleAsync(People people) {
            // Marca a pessoa como modificada no contexto do banco de dados
            _peopleContext.Peoples.Update(people);
            // Salva as alterações no banco de dados
            await _peopleContext.SaveChangesAsync();

            // Retorna um código de resposta 200 (OK) para indicar que a operação foi concluída com sucesso
            return Ok();
        }

        //O método DeletePeopleForId usa uma operação de escrita para excluir uma pessoa existente com base em um ID fornecido.
        // Método que exclui uma pessoa existente no banco de dados com base no ID fornecido
        [HttpDelete("{peopleId}")]
        public async Task<ActionResult<People>> DeletePeopleForId(Guid peopleId){
            // Procura no banco de dados a pessoa com o ID fornecido
            People people = await _peopleContext.Peoples.FindAsync(peopleId);
            if (people == null) {
                return NotFound();
            }
            // Remove a pessoa do contexto do banco de dados
            _peopleContext.Remove(people);
            // Salva as alterações no banco de dados
            await _peopleContext.SaveChangesAsync();

            // Retorna um código de resposta 200 (OK) para indicar que a operação foi concluída com sucesso
            return Ok();
        }
    }
}

/*
    Em todos os métodos, as alterações no banco de dados são salvas usando o método SaveChangesAsync. Eles também retornam um código de resposta 200 (OK) se a operação for concluída com sucesso.

    O controlador também possui atributos ApiController e Route que especificam que ele é um controlador de API e define a rota base para todas as solicitações neste controlador. A rota base é "api/People", que é definida usando o atributo [Route("api/[controller]")], onde [controller] é o nome do controlador em caixa alta, no caso, "PeopleController".
*/

/*
    A classe ControllerBase é uma classe base que define as funcionalidades comuns de um controlador em uma aplicação ASP.NET Core MVC. Esta classe é usada como base para a definição de controladores que lidam com solicitações HTTP em um aplicativo ASP.NET Core.

    Ela fornece várias propriedades e métodos que são úteis na construção de uma API, incluindo:

    Propriedades de configuração, como Request, Response, RouteData e HttpContext, que fornecem informações sobre a solicitação HTTP atual.
    Métodos de retorno de resultados, como Ok, BadRequest, NotFound, CreatedAtAction, que permitem que os controladores retornem diferentes tipos de resposta HTTP.
    Métodos de validação, como ModelState.IsValid e ModelState.AddModelError, que permitem validar o modelo recebido na solicitação.
    Em resumo, a classe ControllerBase fornece um conjunto de recursos úteis que simplificam a construção de controladores em uma aplicação ASP.NET Core. Quando criamos um controlador em nossa aplicação, geralmente herdamos da classe ControllerBase para obter acesso aos recursos comuns que ela fornece.
*/

/*
    O async e o await são recursos introduzidos no .NET Framework 4.5 para facilitar a programação assíncrona. Com o lançamento do .NET 6.0, esses recursos foram aprimorados e continuam sendo úteis para executar operações assíncronas de forma mais eficiente em aplicativos.

    A palavra-chave async é usada para indicar que um método é assíncrono. Isso significa que ele pode ser executado de forma assíncrona em uma thread separada, sem bloquear a thread principal do aplicativo. Quando um método é marcado com async, ele pode retornar uma Task ou uma Task<T>, que representa uma operação assíncrona que pode ser executada em segundo plano.

    O await é usado dentro de um método assíncrono para aguardar a conclusão de uma operação assíncrona, sem bloquear a thread principal. Quando um método usa o await, ele é suspenso até que a operação assíncrona seja concluída. Isso permite que a thread principal do aplicativo continue a executar outras operações enquanto aguarda a conclusão da operação assíncrona.

    Em resumo, o async e o await permitem que os desenvolvedores escrevam código mais limpo e mais fácil de ler ao executar operações assíncronas em aplicativos. Eles ajudam a evitar bloqueios de thread e permitem que as operações assíncronas sejam executadas de forma mais eficiente, melhorando a experiência do usuário e aumentando a escalabilidade do aplicativo.
*/

/*
    [HttpGet]
    public async Task<ActionResult<IEnumerable<People>>> ListPeopleAsync() {
        return await _peopleContext.Peoples.ToListAsync();
    }

    Este é um método de um controlador que responde a solicitações HTTP GET. Ele usa o atributo [HttpGet] para indicar que deve ser acionado somente para solicitações HTTP GET.

    O método retorna uma Task de ActionResult que contém uma lista assíncrona de objetos People do banco de dados. O método usa o método ToListAsync() do Entity Framework Core para carregar a lista de pessoas de forma assíncrona.

    A assinatura do método Task<ActionResult<IEnumerable<People>>> indica que ele retorna um objeto Task, que pode ser executado de forma assíncrona, e que o objeto retornado é um ActionResult que encapsula a lista de pessoas IEnumerable<People> que será retornada pela API.

    O tipo ActionResult é usado para permitir que o método retorne diferentes tipos de resultados HTTP, como um código de status OK com um resultado, um código de status 404 Not Found, etc.

    Em resumo, este método é usado para retornar uma lista de todas as pessoas armazenadas no banco de dados, quando é feita uma solicitação GET para a rota /api/People.
*/

/*
    Em C#, uma Task é uma classe que representa uma operação assíncrona, ou seja, uma operação que pode ser executada em segundo plano, sem bloquear a thread principal do aplicativo.

    As Tasks são usadas para executar operações que podem levar tempo, como operações de E/S de disco ou rede, ou para executar tarefas de longa duração em segundo plano. Quando uma Task é criada, ela é colocada em uma fila de tarefas para ser executada em uma thread separada, permitindo que a thread principal continue a executar outras tarefas.

    As Tasks também podem ser compostas para criar tarefas complexas que executam várias operações em sequência ou em paralelo. Além disso, a classe Task fornece métodos para verificar o status da tarefa, aguardar sua conclusão e obter o resultado da operação assíncrona quando ela é concluída.

    A utilização de Tasks é uma técnica importante para melhorar a responsividade e a escalabilidade dos aplicativos, pois permite que operações de longa duração sejam executadas em segundo plano, sem bloquear a thread principal.
*/

/*
    Em um aplicativo, a thread principal é aquela que é responsável por executar o código do aplicativo e lidar com as interações do usuário, como entrada de teclado e mouse. Essa thread é iniciada quando o aplicativo é executado e é mantida em execução durante toda a vida do aplicativo.

    Já uma thread separada é uma segunda thread que é criada para executar uma operação separada em paralelo à thread principal. As threads separadas são usadas para executar operações que podem bloquear a thread principal, como operações de E/S de longa duração, para que o aplicativo possa continuar respondendo às interações do usuário enquanto a operação é executada em segundo plano.

    Programação assíncrona é um modelo de programação que permite que as operações sejam executadas em segundo plano, sem bloquear a thread principal do aplicativo. Isso permite que o aplicativo continue respondendo às interações do usuário enquanto a operação é executada em segundo plano.

    A programação assíncrona é particularmente útil para operações que podem levar tempo, como operações de E/S de disco ou rede. Em vez de bloquear a thread principal enquanto espera que a operação seja concluída, a programação assíncrona permite que o aplicativo continue a executar outras tarefas enquanto a operação é executada em segundo plano.

    Em resumo, a programação assíncrona é uma técnica que permite que os aplicativos executem operações em segundo plano, sem bloquear a thread principal, o que ajuda a melhorar a responsividade do aplicativo e a escalabilidade do sistema. As threads separadas são usadas para executar essas operações em segundo plano, enquanto a thread principal continua a executar outras tarefas.
*/

/*
    Em programação, uma thread é uma sequência de instruções que pode ser executada simultaneamente com outras sequências de instruções em um programa.

    Mais especificamente, uma thread é um fluxo de execução que representa uma tarefa ou um processo separado dentro de um programa. Cada thread é executada em uma única sequência de instruções em um único processador, mas várias threads podem ser executadas em paralelo em vários processadores ou núcleos de processador, permitindo que o programa execute várias tarefas simultaneamente.

    As threads são usadas em programas para melhorar o desempenho e a responsividade do sistema, permitindo que várias tarefas sejam executadas em paralelo. Por exemplo, em um aplicativo gráfico, uma thread pode ser usada para manipular a interface do usuário, enquanto outra thread executa uma operação de E/S de longa duração em segundo plano. Isso permite que o aplicativo continue a responder aos comandos do usuário enquanto a operação de E/S é executada em segundo plano.

    No entanto, a programação com threads pode ser complicada, pois vários threads compartilham recursos do sistema, como memória e dispositivos de E/S, o que pode levar a problemas de sincronização e condições de corrida. Por isso, é importante usar técnicas de programação seguras para evitar esses problemas e garantir que as threads sejam executadas corretamente.
*/

/*
    As Minimal APIs e Controllers são duas abordagens diferentes para criar APIs em C# usando o ASP.NET Core.

    Os Controllers são a abordagem mais tradicional para criar APIs em C#. Os controllers são classes que contêm métodos que correspondem a operações HTTP, como GET, POST, PUT e DELETE. Cada método no controller é decorado com um atributo que define a rota da API e outros detalhes, como autorização e tipos de resposta.

    As Minimal APIs, por outro lado, são uma abordagem mais recente e simplificada para criar APIs em C#. Com as Minimal APIs, você pode criar APIs sem a necessidade de criar um controller separado. Em vez disso, você pode definir suas rotas e implementações diretamente no método Main() do aplicativo, usando uma abordagem semelhante ao roteamento de middleware.

    A principal diferença entre as duas abordagens é a complexidade. Os Controllers fornecem uma estrutura mais completa para lidar com APIs maiores e mais complexas, enquanto as Minimal APIs são mais simples e leves, sendo mais adequadas para APIs menores e mais simples.

    Além disso, as Minimal APIs também têm a vantagem de serem mais rápidas e leves, pois eliminam a sobrecarga e a complexidade adicionais de criar um controller separado. No entanto, elas podem não ser adequadas para casos de uso mais avançados, onde é necessário mais controle e flexibilidade na construção de APIs.
*/

/*
    As Minimal APIs e Controllers são duas abordagens diferentes para criar APIs em C# usando o ASP.NET Core.

    Os Controllers são a abordagem mais tradicional para criar APIs em C#. Os controllers são classes que contêm métodos que correspondem a operações HTTP, como GET, POST, PUT e DELETE. Cada método no controller é decorado com um atributo que define a rota da API e outros detalhes, como autorização e tipos de resposta.

    As Minimal APIs, por outro lado, são uma abordagem mais recente e simplificada para criar APIs em C#. Com as Minimal APIs, você pode criar APIs sem a necessidade de criar um controller separado. Em vez disso, você pode definir suas rotas e implementações diretamente no método Main() do aplicativo, usando uma abordagem semelhante ao roteamento de middleware.

    A principal diferença entre as duas abordagens é a complexidade. Os Controllers fornecem uma estrutura mais completa para lidar com APIs maiores e mais complexas, enquanto as Minimal APIs são mais simples e leves, sendo mais adequadas para APIs menores e mais simples.

    Além disso, as Minimal APIs também têm a vantagem de serem mais rápidas e leves, pois eliminam a sobrecarga e a complexidade adicionais de criar um controller separado. No entanto, elas podem não ser adequadas para casos de uso mais avançados, onde é necessário mais controle e flexibilidade na construção de APIs.
*/