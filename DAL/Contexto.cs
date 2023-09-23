using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{

    public DbSet<Tickets> Tickets {get; set;}

    public Contexto(DbContextOptions <Contexto> options): base (options)
    {
    }
}