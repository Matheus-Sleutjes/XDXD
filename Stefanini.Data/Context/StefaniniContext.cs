using Microsoft.EntityFrameworkCore;
using Stefanini.Domain.Model;

namespace Stefanini.Data.Context
{
    public class StefaniniContext(DbContextOptions<StefaniniContext> options) : DbContext(options)
    {
        public required DbSet<Produto> Produto { get; set; }
        public required DbSet<Pedido> Pedido { get; set; }
        public required DbSet<ItensPedido> itensPedidos { get; set; }
    }
}