using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalHerramientas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lugar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Dias = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIda = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaRegreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pais = table.Column<int>(type: "INTEGER", nullable: false),
                    FotoRuta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lugar");
        }
    }
}
