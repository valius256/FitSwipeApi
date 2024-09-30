using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Paging;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FitSwipe.DataAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly FitSwipeDbContext _context;

        public GenericRepository(FitSwipeDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> FindOneAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> FindWithNoTrackingAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).AsNoTracking().ToListAsync();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            await SaveChangesWithTransactionAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.AddRangeAsync(entities);
            await SaveChangesWithTransactionAsync();
            return entities;
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            var enumerable = entities as TEntity[] ?? entities.ToArray();
            if (enumerable.Any())
            {
                _context.Set<TEntity>().RemoveRange(enumerable);
                await SaveChangesWithTransactionAsync();
            }
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            var enumerable = entities as TEntity[] ?? entities.ToArray();
            if (enumerable.Any())
            {
                _context.Set<TEntity>().UpdateRange(enumerable);
                await SaveChangesWithTransactionAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            //_context.Entry(entity).State = EntityState.Detached;
            _context.Update(entity);
            await SaveChangesWithTransactionAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await SaveChangesWithTransactionAsync();
            }
        }



        public async Task<bool> Exists(Guid id)
        {
            var entity = await GetByIdAsync(id);
            return entity != null;
        }

        public async Task<TEntity?> FindOneWithNoTrackingAsync(Expression<Func<TEntity, bool>> expression)
        {
            var dbObject = await _context.Set<TEntity>().Where(expression).AsNoTracking().FirstOrDefaultAsync();
            return dbObject;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public virtual Task<PagedResult<TEntity>> PagingAsync<T>(PagingModel<T> request)
        {
            return _context.Set<TEntity>()
                //.OrderProperty(request.Sorts)
                .ToPagingAsync<TEntity, TEntity>(request.Page, request.Limit);
        }

        public virtual Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request, Func<List<TEntity>, List<T>> mapping)
        {
            return _context.Set<TEntity>()
                //.OrderProperty(request.Sorts)
                .ToPagingAsync(request.Page, request.Limit, mapping);
        }

        public async Task<PagedResult<T>> ToPagingAsync<T, V>(
            IQueryable<TEntity> query,
            int page, int limit)
        {
            var result = new PagedResult<T>
            {
                Total = await query.CountAsync(),
                Page = page,
                Limit = limit
            };

            List<TEntity> items;
            if (limit > 0)
            {
                var startIndex = page * limit;
                items = await query
                    .Skip(startIndex < 0 ? 0 : startIndex)
                    .Take(limit)
                    .ToListAsync();
            }
            else
            {
                items = await query.ToListAsync();
            }

            // Use Mapster for mapping
            result.Items = items.Adapt<List<T>>();

            return result;
        }

        public virtual Task<PagedResult<TEntity>> PagingAsync<T>(PagingModel<T> request,
            Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                //.OrderProperty(request.Sorts)
                .ToPagingAsync<TEntity, TEntity>(request.Page, request.Limit);
        }


        public virtual Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request,
            Expression<Func<TEntity, bool>> predicate, Func<List<TEntity>, List<T>> mapping)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                //.OrderProperty(request.Sorts)
                .ToPagingAsync(request.Page, request.Limit, mapping);
        }


        public Task<PagedResult<T>> PagingAsync<F, T>(PagingModel<F> request,
            Expression<Func<TEntity, bool>> predicate,
            Func<List<TEntity>, List<T>> mapping,
            params (string key, string val)[] propertyMapping)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                //.OrderProperty(request.Sorts, propertyMapping)
                .ToPagingAsync(request.Page, request.Limit, mapping);
        }


        public Task<List<T>> GetOptionModelAsync<T>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, T>> selector
        )
        {
            return _context.Set<TEntity>().Where(predicate)
                .Select(selector)
                .ToListAsync();
        }

        public int SaveChangesWithTransaction()
        {
            int result = -1;

            //System.DataAccess.IsolationLevel.Snapshot
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    result = _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    result = -1;
                    dbContextTransaction.Rollback();
                }
            }

            return result;
        }

        public async Task<int> SaveChangesWithTransactionAsync()
        {
            int result = -1;

            //System.DataAccess.IsolationLevel.Snapshot
            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    result = await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    result = -1;
                    dbContextTransaction.Rollback();
                }
            }

            return result;
        }


    }
}
