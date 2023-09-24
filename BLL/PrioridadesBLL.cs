using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class PrioridadesBLL
{
    private Contexto _contexto;
    
    public PrioridadesBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Existe(int PrioridadId)
    {
        return _contexto.Prioridades.Any(p => p.PrioridadId == PrioridadId);
    }

    public bool Insertar(Prioridades prioridades)
    {
        _contexto.Prioridades.Add(prioridades);
        int guardado = _contexto.SaveChanges();
        return guardado > 0;
    }

    public bool Modificar(Prioridades prioridades)
    {
        _contexto.Update(prioridades);
        int modificado = _contexto.SaveChanges();
        return modificado > 0;
    }

    public bool Guardar(Prioridades prioridades)
    {
        if(!Existe(prioridades.PrioridadId))
        {
            return Insertar(prioridades);
        }
        else
        {
            return Modificar(prioridades);
        }
    }

    public Prioridades? Buscar(int PrioridadId)
    {
        return _contexto.Prioridades
            .AsNoTracking()
            .SingleOrDefault(p => p.PrioridadId == PrioridadId);
    }

    public bool Eliminar(Prioridades prioridades)
    {
        _contexto.Prioridades.Remove(prioridades);
        int eliminado = _contexto.SaveChanges();
        return eliminado > 0;
    }

    public List<Prioridades> Listar(Expression<Func<Prioridades, bool>> Criterio){
        return _contexto.Prioridades
            .Where(Criterio)
            .AsNoTracking().ToList();
    }
}