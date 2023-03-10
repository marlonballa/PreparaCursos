// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPortfolio;

#nullable disable

namespace MyPortfolio.Migrations
{
    [DbContext(typeof(MyPortfolioContext))]
    partial class MyPortfolioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Contact", b =>
                {
                    b.Property<Guid>("IdContact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfContact")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageContatc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectContatc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdContact");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
