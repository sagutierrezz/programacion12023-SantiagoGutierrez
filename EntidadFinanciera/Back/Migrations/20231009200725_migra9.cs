using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migra9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "CuentasBancarias",
                newName: "PropietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_CuentasBancarias_ClienteId",
                table: "CuentasBancarias",
                newName: "IX_CuentasBancarias_PropietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_PropietarioId",
                table: "CuentasBancarias",
                column: "PropietarioId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_PropietarioId",
                table: "CuentasBancarias");

            migrationBuilder.RenameColumn(
                name: "PropietarioId",
                table: "CuentasBancarias",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_CuentasBancarias_PropietarioId",
                table: "CuentasBancarias",
                newName: "IX_CuentasBancarias_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
