using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migra112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasBancarias_Clientes_PropietarioId",
                table: "CuentasBancarias");

            migrationBuilder.DropIndex(
                name: "IX_CuentasBancarias_PropietarioId",
                table: "CuentasBancarias");

            migrationBuilder.DropColumn(
                name: "PropietarioId",
                table: "CuentasBancarias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropietarioId",
                table: "CuentasBancarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_PropietarioId",
                table: "CuentasBancarias",
                column: "PropietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasBancarias_Clientes_PropietarioId",
                table: "CuentasBancarias",
                column: "PropietarioId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
