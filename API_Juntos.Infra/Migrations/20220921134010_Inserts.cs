using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Juntos.Infra.Migrations
{
    public partial class Inserts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO clientes values (1,'Mayara Campos', '98764524318', 'may.sarr@yahoo.com.br', '71987653425', 'Rua Telonio, n. 16, Salvador');");
            migrationBuilder.Sql("INSERT INTO produtos values (1,'Argamassa ACII', '675GH', '36 meses', 20.00, 'kg', 29.80, 35);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
