using MaquinaCafeVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace MaquinaCafeVirtual.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<MaquinaCafeVirtual.Models.Moeda> Moeda { get; set; }
    }
}
