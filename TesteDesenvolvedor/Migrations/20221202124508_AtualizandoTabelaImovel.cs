using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteDesenvolvedor.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelaImovel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_Clientes_ClienteId",
                table: "Imoveis");

            migrationBuilder.DropIndex(
                name: "IX_Imoveis_ClienteId",
                table: "Imoveis");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Imoveis");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Clientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Imoveis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_ClienteId",
                table: "Imoveis",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_Clientes_ClienteId",
                table: "Imoveis",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }
    }
}
