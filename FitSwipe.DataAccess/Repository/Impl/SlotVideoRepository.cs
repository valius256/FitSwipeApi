using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class SlotVideoRepository : GenericRepository<SlotVideos>, ISlotVideoRepository
    {
        public SlotVideoRepository(FitSwipeDbContext context) : base(context)
        {
        }
    }
}
