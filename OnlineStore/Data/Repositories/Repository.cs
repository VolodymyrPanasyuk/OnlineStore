using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly OnlineStoreContext _context;
    private readonly DbSet<T> _entities;

    public Repository()
    {
        _context = new OnlineStoreContext();
        _entities = _context.Set<T>();
    }

    public Repository(OnlineStoreContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _entities.Where(predicate).ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _entities.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _entities.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _entities.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _entities.FindAsync(id);
        if (entity != null)
        {
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}