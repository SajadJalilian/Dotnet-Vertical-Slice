using System.Linq.Expressions;
using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly DbContext _dbContext;

    protected Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    #region Queries

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbContext.Set<TEntity>().AnyAsync(predicate);
    }

    #endregion

    #region Commands

    public void Add(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
    }

    public void Add(IEnumerable<TEntity> entities)
    {
        _dbContext.Set<TEntity>().AddRange(entities);
    }

    public void Remove(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
    }

    public void Remove(IEnumerable<TEntity> entities)
    {
        _dbContext.Set<TEntity>().RemoveRange(entities);
    }

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
    }

    public void Update(IEnumerable<TEntity> entities)
    {
        _dbContext.Set<TEntity>().UpdateRange(entities);
    }

    #endregion
}