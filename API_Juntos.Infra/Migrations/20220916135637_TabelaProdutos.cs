using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Juntos.Infra.Migrations
{
    public partial class TabelaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Lote = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Validade = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    QuantidadeEmbalagem = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Valor = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    QuantidadeEstoque = table.Column<decimal>(type: "DECIMAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.IdProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
