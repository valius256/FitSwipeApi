
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(FitSwipeDbContext context) : base(context)
        {
        }
    }
}
