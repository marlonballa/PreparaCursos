using MyPortfolio;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//[7]
builder.Services.AddSqlServer<MyPortfolioContext>(builder.Configuration.GetConnectionString("ServerConnection"));

//[8]
builder.Services.AddCors();
/*
 O código builder.Services.AddCors() é usado para adicionar a política de CORS (Cross-Origin Resource Sharing) ao aplicativo ASP.NET Core. O CORS é um mecanismo que permite que recursos restritos em um site sejam solicitados por outro site de origem diferente.
O método AddCors() adiciona o serviço de política de CORS ao contêiner de serviços do aplicativo, permitindo que o middleware de CORS manipule as solicitações de entrada e saída do aplicativo. Isso permite que você configure a política de CORS para permitir ou negar solicitações de recursos entre diferentes origens.
A configuração da política de CORS é feita através do método services.AddCors() e adicionando a política desejada usando o método app.UseCors() no pipeline de middleware do aplicativo.
 */

var app = builder.Build();

// Configure the HTTP request pipeline.
//O Swagger será utilizado fora do ambiente de desenvolvimento
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

//[8]
app.UseCors(p => p
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod()
);
/*
   Esse código configura o middleware de Cors (Cross-Origin Resource Sharing) na aplicação.
   O Cors é um mecanismo de segurança que impede que recursos em um site da web sejam acessados ​​por outro site da web. O middleware de Cors permite que a aplicação permita ou restrinja o acesso de solicitações de outros sites.
   O método app.UseCors() define uma política de Cors, que neste caso está permitindo qualquer origem, cabeçalho e método através do uso dos métodos AllowAnyOrigin(), AllowAnyHeader() e AllowAnyMethod(), respectivamente. Essa configuração é útil em casos em que a aplicação precisa permitir acesso de qualquer site. No entanto, é importante ressaltar que essa configuração pode representar um risco de segurança se não for utilizada corretamente. 
 */


//[11]
//Este post é o responsável por guardar no banco de dados as informações do formulário
app.MapPost("/contact", async (MyPortfolioContext myPortfolio, Contact contact) =>
{
    await myPortfolio.Contacts.AddAsync(contact);
    await myPortfolio.SaveChangesAsync();

    return Results.Ok(contact);
});
/*
 * 
 * Esse código configura uma rota POST para o aplicativo, que aceita uma instância de um objeto do tipo         MyPortfolioContext e um objeto do tipo Contact como parâmetros.
    O método MapPost é um método de extensão do objeto IApplicationBuilder usado para mapear uma rota HTTP POST para um manipulador de solicitação no aplicativo.
    Ao receber uma solicitação HTTP POST, o aplicativo adiciona o objeto Contact ao contexto do banco de dados representado pelo objeto myPortfolio, que é uma instância da classe MyPortfolioContext. Em seguida, o aplicativo salva as alterações no banco de dados usando o método SaveChangesAsync.
    Por fim, o método retorna uma resposta HTTP OK (código de status 200) com o objeto contact no corpo da resposta.
 */

app.MapGet("/listContacts", async (MyPortfolioContext myPortfolio) =>
{
    var listContacts = await myPortfolio.Contacts.ToListAsync();

    return Results.Ok(listContacts);
});
/*
 * Esse código representa uma rota do ASP.NET Core que escuta uma solicitação HTTP GET no caminho /listContacts. Quando uma solicitação GET é recebida, ele usa o objeto MyPortfolioContext para obter uma lista de contatos do banco de dados. Em seguida, essa lista é retornada como uma resposta HTTP 200 com o conteúdo JSON, usando o método Results.Ok().

    Mais especificamente:

    app.MapGet(): registra uma rota para lidar com solicitações HTTP GET.
    "/listContacts": o caminho da rota que deve ser usado para acessar a ação do controlador correspondente.

    async (MyPortfolioContext myPortfolio) => { ... }: o manipulador de solicitação que será executado quando essa rota for acessada. Recebe uma instância de MyPortfolioContext injetada como um parâmetro. O manipulador é assíncrono, indicado pela palavra-chave async.

    var listContacts = await myPortfolio.Contacts.ToListAsync();: obtém todos os contatos do banco de dados usando o objeto MyPortfolioContext injetado, e os armazena na variável listContacts.

    return Results.Ok(listContacts);: retorna uma resposta HTTP 200 com o conteúdo JSON da variável listContacts, usando o método Results.Ok() do ASP.NET Core.
 */

app.Run();

//Classe que constrói o objeto "Contact"
public class Contact
{
    [Key]
    public Guid IdContact { get; set; }
    /*
     * GUID (Globally Unique Identifier) é um identificador único globalmente, que é um número de 128 bits usado em aplicativos de software, principalmente em bancos de dados, para criar identificadores exclusivos para registros. É um valor que é gerado aleatoriamente e garantido para ser exclusivo em todo o mundo, mesmo quando gerado em diferentes computadores em diferentes momentos. O tipo Guid é uma estrutura em C# que representa um GUID.
     */

    public string NameContact { get; set; } = string.Empty;
    public string EmailContact { get; set; } = string.Empty;
    public string SubjectContatc { get; set; } = string.Empty;
    public string MessageContatc { get; set; } = string.Empty;
    public DateTime DateOfContact { get; set; }

}