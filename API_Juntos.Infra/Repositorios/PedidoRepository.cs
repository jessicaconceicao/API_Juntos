using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API_Juntos.Infra.Repositorios
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext _context;

        public PedidoRepository(ApplicationContext context)
        {
            _context = context;
        }


        /*public async Task Atualizar(Pedido obj)
        {
            throw new NotImplementedException();
        }*/
        public async Task Excluir(Pedido obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public async Task Inserir(Pedido obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<Pedido> ListarPorId(int id)
        {
            return await _context
                .Pedidos
                .Include(x => x.ProdutosDoPedido)
                    .ThenInclude(x => x.Produto)
                .Where(p => p.IdPedido == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Pedido>> ListarTodos()
        {
            return await _context
                .Pedidos
                .Include(x => x.ProdutosDoPedido)
                    .ThenInclude(x => x.Produto)
                .AsNoTracking()
                .ToListAsync();
        }


    }
}
