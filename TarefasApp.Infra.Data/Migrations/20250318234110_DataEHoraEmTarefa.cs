using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarefasApp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataEHoraEmTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DATA",
                table: "TAREFA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HORA",
                table: "TAREFA",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DATA",
                table: "TAREFA");

            migrationBuilder.DropColumn(
                name: "HORA",
                table: "TAREFA");
        }
    }
}
