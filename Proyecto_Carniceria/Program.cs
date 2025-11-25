using Microsoft.EntityFrameworkCore;
using Proyecto_Carniceria.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

// Obtener cadena de conexión SQLite
var sqliteConStr = builder.Configuration.GetConnectionString("SqliteConStr");

// Registrar DbContext usando SQLite
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(sqliteConStr)
);

var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
