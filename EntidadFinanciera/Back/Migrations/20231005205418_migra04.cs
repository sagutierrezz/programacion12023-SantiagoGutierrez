using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migra04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_TarjetasCredito_Clientes_ClienteId",
                table: "TarjetasCredito");

            migrationBuilder.DropIndex(
                name: "IX_TarjetasCredito_ClienteId",
                table: "TarjetasCredito");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "TarjetasCredito");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "CuentasBancarias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "TarjetasCredito",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "CuentasBancarias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TarjetasCredito_ClienteId",
                table: "TarjetasCredito",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TarjetasCredito_Clientes_ClienteId",
                table: "TarjetasCredito",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
