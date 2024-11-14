using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Transactions;

namespace FitSwipe.BusinessLogic.Interfaces.Transactions
{
    public interface ITransactionServices
    {
        Task<GetTransactionWithUserDto> CreateTransactionAsync(CreateTransactionDtos createTransactionDtos);
        Task<PagedResult<GetTransactionWithUserDto>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagedRequest, string userFirebaseId);
        Task<Transaction> GetTransactionByOrderCodeAsync(long orderCode);
        Task<bool> UpdateTransactionStatus(long orderCode, Shared.Enum.TransactionStatus status);

    }
}
