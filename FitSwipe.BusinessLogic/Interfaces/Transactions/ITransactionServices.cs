using FitSwipe.Shared.Dtos.Transactions;

namespace FitSwipe.BusinessLogic.Interfaces.Transactions
{
    public interface ITransactionServices
    {
        Task<GetSimpleTransactionDtos> CreateTransactionAsync(CreateTransactionDtos createTransactionDtos);
    }
}
