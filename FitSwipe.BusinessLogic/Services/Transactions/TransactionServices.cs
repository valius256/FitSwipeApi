using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Transactions;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Transactions
{
    public class TransactionServices : ITransactionServices
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionServices(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<GetSimpleTransactionDtos> CreateTransactionAsync(CreateTransactionDtos createTransactionDtos)
        {

            var convertTransactionToListString = createTransactionDtos.SlotIds.ConvertAll(x => x.ToString());

            var transaction = new Transaction
            {
                TranscationCode = createTransactionDtos.TranscationCode,
                Method = createTransactionDtos.Method,
                Status = Shared.Enum.TransactionStatus.Successed,
                UserFireBaseId = createTransactionDtos.UserFireBaseId,
                Amount = createTransactionDtos.Amount,
                Description = $"Thanh toán cho slot: {convertTransactionToListString}"
            };

            // Create TransactionSlots for each SlotId
            foreach (var slotId in createTransactionDtos.SlotIds)
            {
                var transactionSlot = new TransactionSlot
                {
                    SlotId = slotId,
                    Transaction = transaction
                };
                transaction.TransactionSlots.Add(transactionSlot);
            }

            await _transactionRepository.AddAsync(transaction);
            return transaction.Adapt<GetSimpleTransactionDtos>();
        }

        public async Task<PagedResult<GetSimpleTransactionDtos>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagedRequest, string userFirebaseId)
        {
            var pagedResultTransactionEntity = await _transactionRepository.GetTransactionsPageAsync(pagedRequest, userFirebaseId);
            return pagedResultTransactionEntity.Adapt<PagedResult<GetSimpleTransactionDtos>>();
        }


    }
}
