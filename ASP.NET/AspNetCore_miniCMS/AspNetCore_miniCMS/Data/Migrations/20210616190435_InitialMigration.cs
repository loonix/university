using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteudo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pagina = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conteudo");
        }
    }
}
