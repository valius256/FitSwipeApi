using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.BusinessLogic.Services.Slots
{
    public class SlotTransactionServices : ISlotTransactionServices
    {
        private readonly ISlotTransactionRepository _slotTransactionRepository;

        public SlotTransactionServices(ISlotTransactionRepository slotTransactionRepository)
        {
            _slotTransactionRepository = slotTransactionRepository;
        }

        public async Task<List<TransactionSlot>> GetAllTransactionSlotByTransactionId(Guid transactionId)
        {
            return (await _slotTransactionRepository.FindWithNoTrackingAsync(st => st.TransactionId == transactionId)).ToList();
        }
    }
}
