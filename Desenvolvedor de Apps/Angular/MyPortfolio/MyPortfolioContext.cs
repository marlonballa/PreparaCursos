using Microsoft.EntityFrameworkCore;

namespace MyPortfolio
{
    //A classe MyPortfolioContext está herdando da classe DbContext (a classe mais importante do Entity FrameWork, pois é a responsável por gerenciar o acesso aos dados e o mapeamento de objetos para tabelas do banco de dados)
    public class MyPortfolioContext : DbContext
    {
        //Construtor da classe
        public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options) : base(options)
        { }

        /*
            Explicação sobre a classe: DbCOntext

            A classe DbContext é uma classe fundamental da biblioteca de acesso a dados do .NET, o Entity Framework. Ela funciona como um intermediário entre o seu código e o banco de dados, permitindo que você escreva consultas e alterações de dados de uma maneira simples e orientada a objetos. O DbContext é responsável por gerenciar a conexão com o banco de dados, controlar transações, gerenciar objetos que representam registros do banco de dados e muito mais. Basicamente, ele é a classe que conecta o seu código ao banco de dados e permite que você execute operações nele.
         */

        /*
          Explicação sobre a classe DbContextOptions

            A classe DbContextOptions é usada para configurar opções para o DbContext, como a cadeia de conexão com o banco de dados, o provedor de banco de dados e outras opções relacionadas ao DbContext. Basicamente, ela permite que você defina as configurações necessárias para o DbContext trabalhar com o banco de dados da sua aplicação.
         */

        /*
            Explicações sobre o Construtor

           O construtor da classe MyAppContext recebe um objeto do tipo DbContextOptions<MyAppContext> como parâmetro. Esse objeto contém opções de configuração que serão utilizadas pelo DbContext para se conectar ao banco de dados e executar as operações de CRUD (create, read, update e delete) nas entidades.

           Ao chamar o construtor da classe base DbContext com o objeto options recebido, estamos passando essas opções de configuração para o DbContext, que irá utilizá-las para se conectar ao banco de dados e configurar o comportamento das operações de CRUD. Assim, é possível personalizar o comportamento do DbContext e a conexão com o banco de dados de acordo com as necessidades da aplicação.
         */

        //Mapeando as tabelas (deve ser feito para cada Entidade existente no banco de dados)
        public DbSet<Contact> Contacts { get; set; }

        //Mapeando a connectionString do Banco de Dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }

        //ServerConnection: Realiza o mapeamento da String de Conexão

        /*
         Esse código é responsável por configurar o banco de dados que será utilizado pela aplicação.

        Primeiro, é criada uma instância de IConfiguration, que é responsável por ler e fornecer acesso às configurações da aplicação. Nesse exemplo, é criada uma nova instância a partir de um arquivo JSON localizado na mesma pasta do aplicativo.

        Em seguida, o objeto optionsBuilder é usado para configurar o provedor de banco de dados que será usado pela aplicação. Nesse exemplo, está sendo utilizado o provedor de banco de dados SQL Server. O método UseSqlServer recebe uma string com a conexão com o banco de dados, que é obtida a partir do arquivo de configuração usando o método GetConnectionString.

        Basicamente, esse código está definindo as configurações para acessar o banco de dados e indicando qual provedor de banco de dados deve ser utilizado pela aplicação.
         */
    }
}
