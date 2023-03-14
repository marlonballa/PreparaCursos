using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularDotNet.API.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    idPeople = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    namePeople = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNamePeople = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agePeople = table.Column<int>(type: "int", nullable: false),
                    professionPeople = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.idPeople);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
