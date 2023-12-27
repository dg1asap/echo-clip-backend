using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected DbContext _context;

    protected DbSet<T> _table;

    public GenericRepository(DatabaseEchoClipContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _table.ToList();
    }

    public T GetById(object id)
    {
        return _table.Find(id);
    }

    public void Insert(T obj)
    {
        _table.Add(obj);
    }

    public void Update(T obj)
    {
        _table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
    }

    public void Delete(object id)
    {
        T existing = _table.Find(id);
        _table.Remove(existing);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
