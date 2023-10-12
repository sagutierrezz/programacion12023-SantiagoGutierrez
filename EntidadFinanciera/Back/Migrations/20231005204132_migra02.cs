using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migra02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "CuentasBancarias",
                newName: "TipoCuentaBancaria");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroCuenta",
                table: "CuentasBancarias",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoCuentaBancaria",
                table: "CuentasBancarias",
                newName: "Tipo");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroCuenta",
                table: "CuentasBancarias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
