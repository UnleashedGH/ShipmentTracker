using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected RepositoryContext RepositoryContext;
    public BaseRepository(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;

    public IQueryable<T> GetAll(bool trackChanges)
    {
        IQueryable<T> result;
        if (!trackChanges)
             result = RepositoryContext.Set<T>().AsNoTracking();
        else
        {
            result = RepositoryContext.Set<T>();
        }

        return result;
    }
    

    public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        IQueryable<T> result;
        if (!trackChanges)
            result = RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        else
        {
            result = RepositoryContext.Set<T>().Where(expression);
        }

        return result;

    } 
    public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
    public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
    public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
}