using ClassLibrary1.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.DAL.Repositories.Context;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly DbCONTEXT _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository()
    {
        _context = new DbCONTEXT();
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        entity.CreatedDate = DateTime.Now;
    }

    public void Delete(int Id)
    {
        var entity = _dbSet.FirstOrDefault(e => e.Id == Id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.Now;
        }
        else
            throw new NullReferenceException();
    }

    public ICollection<T> GetAll()
    {
        return _dbSet.Where(t => t.IsDeleted == false).ToList();
    }

    public T GetById(int Id)
    {
        return _dbSet.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update(int Id)
    {
        throw new Exception();
    }
}
