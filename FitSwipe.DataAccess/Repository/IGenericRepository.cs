using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Paging;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace FitSwipe.DataAccess.Repository
{

    public interface IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task<TEntity?> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> FindOneAsync(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity?> FindOneWithNoTrackingAsync(Expression<Func<TEntity, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);


        Task<PagedResult<TEntity>> PagingAsync<T>(PagingModel<T> request);

        Task<PagedResult<TEntity>> PagingAsync<T>(PagingModel<T> request, Expression<Func<TEntity, bool>> predicate);

        Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request, Func<List<TEntity>, List<T>> mapping);

        Task<PagedResult<T>> ToPagingAsync<T, V>(
            IQueryable<TEntity> query,
            int page, int limit);

        Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request,
            Expression<Func<TEntity, bool>> predicate, Func<List<TEntity>, List<T>> mapping);

        Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request,
            Expression<Func<TEntity, bool>> predicate, Func<List<TEntity>, List<T>> mapping,
            params (string key, string val)[] propertyMapping);

        Task<List<T>> GetOptionModelAsync<T>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, T>> selector
        );
    }
}
