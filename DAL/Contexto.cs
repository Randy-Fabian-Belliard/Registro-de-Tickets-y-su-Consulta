using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{

    public DbSet<Tickets> Tickets {get; set;}
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Sistemas> Sistemas { get; set; }
    public DbSet<Prioridades> Prioridades { get; set; }

    public Contexto(DbContextOptions <Contexto> options): base (options)
    {
    }
}