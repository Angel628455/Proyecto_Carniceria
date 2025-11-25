using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Carniceria.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeLaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarritoDeCompras",
                columns: table => new
                {
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<string>(type: "TEXT", nullable: false),
                    MontoTotal = table.Column<float>(type: "REAL", nullable: false),
                    Compra = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoDeCompras", x => x.CarritoId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaCarnes",
                columns: table => new
                {
                    CategoriaCarnesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaCarnes", x => x.CategoriaCarnesId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Estadisticas",
                columns: table => new
                {
                    EstadisticaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalPedidos = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalPagos = table.Column<int>(type: "INTEGER", nullable: false),
                    IngresosTotales = table.Column<float>(type: "REAL", nullable: false),
                    TotalClientes = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalProductos = table.Column<int>(type: "INTEGER", nullable: false),
                    VentasHoy = table.Column<float>(type: "REAL", nullable: false),
                    PedidosHoy = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.EstadisticaId);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadosId);
                });

            migrationBuilder.CreateTable(
                name: "MetodosPagos",
                columns: table => new
                {
                    MetodoPagoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodosPagos", x => x.MetodoPagoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Contrasena = table.Column<string>(type: "TEXT", nullable: false),
                    ConfirmacionContrasena = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    ImagenProducto = table.Column<string>(type: "TEXT", nullable: true),
                    Codigo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioLibra = table.Column<float>(type: "REAL", nullable: false),
                    CostoLibra = table.Column<float>(type: "REAL", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoriaCarneId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaCarnesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_CategoriaCarnes_CategoriaCarnesId",
                        column: x => x.CategoriaCarnesId,
                        principalTable: "CategoriaCarnes",
                        principalColumn: "CategoriaCarnesId");
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<string>(type: "TEXT", nullable: false),
                    ClienteId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    MontoPagado = table.Column<float>(type: "REAL", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_ClienteId1",
                        column: x => x.ClienteId1,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId");
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<string>(type: "TEXT", nullable: true),
                    Entrega = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Recibido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MontoTotal = table.Column<float>(type: "REAL", nullable: false),
                    EstadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadosId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Estados_EstadosId",
                        column: x => x.EstadosId,
                        principalTable: "Estados",
                        principalColumn: "EstadosId");
                });

            migrationBuilder.CreateTable(
                name: "DetalleProductos",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Productos = table.Column<string>(type: "TEXT", nullable: true),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false),
                    precio = table.Column<float>(type: "REAL", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    CarritoDeComprasCarritoId = table.Column<int>(type: "INTEGER", nullable: true),
                    PedidosPedidoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleProductos", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_DetalleProductos_CarritoDeCompras_CarritoDeComprasCarritoId",
                        column: x => x.CarritoDeComprasCarritoId,
                        principalTable: "CarritoDeCompras",
                        principalColumn: "CarritoId");
                    table.ForeignKey(
                        name: "FK_DetalleProductos_Pedidos_PedidosPedidoId",
                        column: x => x.PedidosPedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId");
                });

            migrationBuilder.CreateTable(
                name: "Detalles_Pagos",
                columns: table => new
                {
                    DetallePagoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PedidosPedidoId = table.Column<int>(type: "INTEGER", nullable: true),
                    PagoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PagosPagoId = table.Column<int>(type: "INTEGER", nullable: true),
                    MetodoPagoId = table.Column<int>(type: "INTEGER", nullable: false),
                    MetodosPagosMetodoPagoId = table.Column<int>(type: "INTEGER", nullable: true),
                    MontoPagado = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_Pagos", x => x.DetallePagoId);
                    table.ForeignKey(
                        name: "FK_Detalles_Pagos_MetodosPagos_MetodosPagosMetodoPagoId",
                        column: x => x.MetodosPagosMetodoPagoId,
                        principalTable: "MetodosPagos",
                        principalColumn: "MetodoPagoId");
                    table.ForeignKey(
                        name: "FK_Detalles_Pagos_Pagos_PagosPagoId",
                        column: x => x.PagosPagoId,
                        principalTable: "Pagos",
                        principalColumn: "PagoId");
                    table.ForeignKey(
                        name: "FK_Detalles_Pagos_Pedidos_PedidosPedidoId",
                        column: x => x.PedidosPedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleProductos_CarritoDeComprasCarritoId",
                table: "DetalleProductos",
                column: "CarritoDeComprasCarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleProductos_PedidosPedidoId",
                table: "DetalleProductos",
                column: "PedidosPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Pagos_MetodosPagosMetodoPagoId",
                table: "Detalles_Pagos",
                column: "MetodosPagosMetodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Pagos_PagosPagoId",
                table: "Detalles_Pagos",
                column: "PagosPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Pagos_PedidosPedidoId",
                table: "Detalles_Pagos",
                column: "PedidosPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteId1",
                table: "Pagos",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadosId",
                table: "Pedidos",
                column: "EstadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaCarnesId",
                table: "Productos",
                column: "CategoriaCarnesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleProductos");

            migrationBuilder.DropTable(
                name: "Detalles_Pagos");

            migrationBuilder.DropTable(
                name: "Estadisticas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CarritoDeCompras");

            migrationBuilder.DropTable(
                name: "MetodosPagos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "CategoriaCarnes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
