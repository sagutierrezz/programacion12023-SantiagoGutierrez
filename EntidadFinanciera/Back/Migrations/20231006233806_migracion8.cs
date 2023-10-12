using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migracion8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CuentasBancarias",
                newName: "IdCuenta");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "CuentasBancarias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_ClienteId",
                table: "CuentasBancarias");

            migrationBuilder.RenameColumn(
                name: "IdCuenta",
                table: "CuentasBancarias",
                newName: "Id");

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
    }
}
