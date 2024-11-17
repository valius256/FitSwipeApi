using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Management;
using FitSwipe.Shared.Dtos.Transactions;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<PagedResult<Transaction>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagedRequest, User user);

        Task<GetDashboardStatDto> GetTransactionStatistic();
    }
}
