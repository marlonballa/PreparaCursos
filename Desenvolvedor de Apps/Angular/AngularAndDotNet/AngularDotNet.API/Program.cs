using AngularDotNet.API.Models;


//Coleção de serviços
var builder = WebApplication.CreateBuilder(args);
    // Add services to the container.
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    //Adicionando a String de Conexão
    builder.Services.AddSqlServer<PeopleContext>(builder.Configuration.GetConnectionString("ServerConnection"));
    //Configurando o CORS
    builder.Services.AddCors();


var app = builder.Build();
    // Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    //Esse código configura o middleware de Cors (Cross-Origin Resource Sharing) na aplicação.
    app.UseCors(options => options
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
    );
    app.UseAuthorization();
    app.MapControllers();
    app.Run();

