using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Transactions;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly FitSwipeDbContext _dbContext;
        public TransactionRepository(FitSwipeDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<PagedResult<Transaction>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagingRequest, string userFirebaseId)
        {
            var query = _dbContext.Transactions.Where(l => l.UserFireBaseId == userFirebaseId).AsQueryable();
            if (pagingRequest.Filter != null)
            {
                query = GetTransactionQuery(query, pagingRequest.Filter);
            }
            int limit = pagingRequest.Limit > 0 ? pagingRequest.Limit : 10;
            int page = pagingRequest.Page > 0 ? pagingRequest.Page : 1;
            return await query.ToNewPagingAsync(page, limit);

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

            var testResult = query.ToList();

            if (filter.Method is not null)
            {
                query = query.Where(l => filter.Method.Contains(l.Method));
            }

            if (filter.Status != null)
            {
                query = query.Where(l => filter.Status.Contains(l.Status));
            }

            if (filter.MinAmount != 0 && filter.MaxAmount != 0)
            {
                query = query.Where(l => l.Amount >= filter.MinAmount && l.Amount <= filter.MaxAmount);
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
