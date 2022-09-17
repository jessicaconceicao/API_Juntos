namespace API_Juntos.Core.Entidades
{
    public class ProdutosDoPedido
    {
        public int IdProdutosDoPedido { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
    }
}
