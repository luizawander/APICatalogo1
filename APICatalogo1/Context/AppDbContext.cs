using APICatalogo1.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo1.Context;

public class AppDbContext : DbContext
{
    // construtor que recebe as opções de configuração do banco de dados
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    //nome da tabela = Categorias
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
}
