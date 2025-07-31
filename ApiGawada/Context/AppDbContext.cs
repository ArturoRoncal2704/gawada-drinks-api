using ApiGawada.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiGawada.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<DetallePedido> DetallesPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definir clave compuesta para DetallePedido
            modelBuilder.Entity<DetallePedido>()
                .HasKey(dp => new { dp.PedidoId, dp.ProductoId });
        }
    }
}
