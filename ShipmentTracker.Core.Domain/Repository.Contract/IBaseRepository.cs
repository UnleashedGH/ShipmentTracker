using System.Linq.Expressions;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IBaseRepository<T>
{
    IQueryable<T> GetAll(bool trackChanges);
    IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}