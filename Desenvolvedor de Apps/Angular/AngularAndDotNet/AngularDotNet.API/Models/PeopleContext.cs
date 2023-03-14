using Microsoft.EntityFrameworkCore;

namespace AngularDotNet.API.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
        //Construtor da classe
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
            //Configurando a connectionstring
        }
    }
}