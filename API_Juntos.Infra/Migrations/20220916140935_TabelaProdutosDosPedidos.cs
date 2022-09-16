using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Juntos.Infra.Migrations
{
    public partial class TabelaProdutosDosPedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtosDosPedidos",
                columns: table => new
                {
                    IdProdutosDoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtosDosPedidos", x => x.IdProdutosDoPedido);
                    table.ForeignKey(
                        name: "FK_produtosDosPedidos_pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produtosDosPedidos_produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtosDosPedidos_IdPedido",
                table: "produtosDosPedidos",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_produtosDosPedidos_IdProduto",
                table: "produtosDosPedidos",
                column: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtosDosPedidos");
        }
    }
}
