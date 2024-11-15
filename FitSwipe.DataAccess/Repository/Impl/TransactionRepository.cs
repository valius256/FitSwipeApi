using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Transactions;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly FitSwipeDbContext _dbContext;
        public TransactionRepository(FitSwipeDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<PagedResult<Transaction>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagingRequest, User user)
        {
            
            var query = _dbContext.Transactions.AsQueryable();

           

            if (pagingRequest.Filter != null)
            {
                query = GetTransactionQuery(query, pagingRequest.Filter);
            }
            if (user.Role != Shared.Enum.Role.Operator)
            {
                if (user.Role == Shared.Enum.Role.Trainee)
                {
                    query = query.Where(l => l.UserFireBaseId == user.FireBaseId);
                } else
                {
                    query = query.Include(l => l.TransactionSlots).ThenInclude(ts => ts.Slot).ThenInclude(s => s.Training)
                        .Where(l => l.UserFireBaseId == user.FireBaseId || l.TransactionSlots.Any(ts => ts.Slot.Training != null && ts.Slot.Training.PTId == user.FireBaseId)); 
                }
            }
            else
            {
                query = query.Include(l => l.User);
            }

            int limit = pagingRequest.Limit > 0 ? pagingRequest.Limit : 10;
            int page = pagingRequest.Page > 0 ? pagingRequest.Page : 1;
            return await query.OrderByDescending(t => t.CreatedDate).ToNewPagingAsync(page, limit);

        }

        private IQueryable<Transaction> GetTransactionQuery(IQueryable<Transaction> query, QueryTransactionDtos filter)
        {
            #region filter
            //if (query is null)
            //{
            //    return null;
            //}

            if (filter.TranscationCode is not null)
            {
                query = query.Where(l => l.TranscationCode.Contains(filter.TranscationCode));
            }

            if (filter.Method is not null)
            {
                query = query.Where(l => filter.Method.Contains(l.Method));
            }

            if (filter.Status != null)
            {
                query = query.Where(l => filter.Status.Contains(l.Status));
            }

            if (filter.MinAmount.HasValue)
            {
                query = query.Where(l => l.Amount >= filter.MinAmount.Value);
            }

            if (filter.MaxAmount.HasValue)
            {
                query = query.Where(l => l.Amount <= filter.MaxAmount.Value);
            }

            if (filter.From.HasValue)
            {
                query = query.Where(l => l.CreatedDate >= filter.From);
            }
            if (filter.To.HasValue)
            {
                query = query.Where(l => l.CreatedDate <= filter.To);
            }

            //if (filter.CreateById != null)
            //{
            //    query = query.Where(l => l.UserFireBaseId == filter.CreateById);
            //}


            #endregion

            return query;
        }
    }
}
