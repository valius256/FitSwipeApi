using FitSwipe.DataAccess.Model.Entity;

namespace FitSwipe.BusinessLogic.Interfaces.Slots
{
    public interface ISlotTransactionServices
    {
        Task<List<TransactionSlot>> GetAllTransactionSlotByTransactionId(Guid transactionId);
    }
}
