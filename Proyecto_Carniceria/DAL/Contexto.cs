using Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Carniceria.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        // Tablas
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<MetodosPagos> MetodosPagos { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Estadisticas> Estadisticas { get; set; }
        public DbSet<Detalles_Pagos> Detalles_Pagos { get; set; }
        public DbSet<DetalleProductos> DetalleProductos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CategoriaCarnes> CategoriaCarnes { get; set; }
        public DbSet<CarritoDeCompras> CarritoDeCompras { get; set; }
    }
}
