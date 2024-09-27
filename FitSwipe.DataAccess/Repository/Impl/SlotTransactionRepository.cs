using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl;

public class SlotTransactionRepository : GenericRepository<TransactionSlot>, ISlotTransactionRepository
{
    public SlotTransactionRepository(FitSwipeDbContext context) : base(context)
    {
    }
}