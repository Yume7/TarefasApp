using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarefasApp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAREFA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TITULO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAREFA", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAREFA");
        }
    }
}
