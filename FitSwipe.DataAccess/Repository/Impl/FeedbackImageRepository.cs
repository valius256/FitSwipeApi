using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class FeedbackImageRepository : GenericRepository<FeedbackImage>, IFeedbackImageRepository
    {
        public FeedbackImageRepository(FitSwipeDbContext context) : base(context)
        {
        }
    }
}
