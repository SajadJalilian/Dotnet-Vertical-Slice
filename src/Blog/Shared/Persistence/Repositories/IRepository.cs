using System.Linq.Expressions;

namespace Blog.Shared.Persistence.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    #region Queries

    Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);

    #endregion

    #region Commands

    void Add(TEntity entity);

    void Add(IEnumerable<TEntity> entities);

    void Remove(TEntity entity);

    void Remove(IEnumerable<TEntity> entities);

    void Update(TEntity entity);

    void Update(IEnumerable<TEntity> entities);

    #endregion
}