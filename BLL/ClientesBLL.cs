using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class ClientesBLL
{

    private Contexto _contexto;

    public ClientesBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Existe(int id)
    {
        return _contexto.Clientes.Any(p =>  p.ClienteId == id);
    }

    private bool Insertar(Clientes clientes)
    {
        _contexto.Clientes.Add(clientes);
        return  _contexto.SaveChanges()> 0;
    }

    private bool Modificar(Clientes clientes)
    {
        _contexto.Entry(clientes).State = EntityState.Modified;
        return _contexto.SaveChanges() > 0;
    }
    public bool Guardar(Clientes cliente)
    {
    if(!ExisteNombre(cliente.Nombre) && !ExisteRnc(cliente.Rnc)  ){

            if(!Existe(cliente.ClienteId))
            return Insertar(cliente);
        else
            return Modificar(cliente);
        }
        return true;

    }

        public bool Eliminar(Clientes cliente){
        bool changes = false;
        try{
            _contexto.Entry(cliente).State = EntityState.Deleted;
            changes = _contexto.SaveChanges() > 0;
            _contexto.Clientes.Entry(cliente).State = EntityState.Detached;
            return changes;
        }
        catch(Exception){
            return false;
        }
    }

        public Clientes? Buscar (int ClienteId){

        return _contexto.Clientes
        .Where( O => O.ClienteId == ClienteId)
        .AsNoTracking()
        .SingleOrDefault();
    }

        public List<Clientes> Listar(Expression<Func<Clientes, bool>> Criterio){
        return _contexto.Clientes
        .Where(Criterio)
        .AsNoTracking().ToList();
    }

        public bool ExisteNombre( string nombre)
        {
            return _contexto.Clientes.Any( p => p.Nombre == nombre);
        }
        public bool ExisteRnc( string rnc)
        {
            return _contexto.Clientes.Any( p => p.Rnc == rnc);
        }
        
}