using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class SlotRepository : GenericRepository<Slot>, ISlotRepository
    {
        private readonly FitSwipeDbContext _context;
        public SlotRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
