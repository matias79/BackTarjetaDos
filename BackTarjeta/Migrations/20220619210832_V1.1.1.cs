using Microsoft.EntityFrameworkCore.Migrations;

namespace BackTarjeta.Migrations
{
    public partial class V111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BDTarjetaCredito",
                table: "BDTarjetaCredito");

            migrationBuilder.RenameTable(
                name: "BDTarjetaCredito",
                newName: "CreditoTarjeta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditoTarjeta",
                table: "CreditoTarjeta",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditoTarjeta",
                table: "CreditoTarjeta");

            migrationBuilder.RenameTable(
                name: "CreditoTarjeta",
                newName: "BDTarjetaCredito");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BDTarjetaCredito",
                table: "BDTarjetaCredito",
                column: "Id");
        }
    }
}
