
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class ReportImageRepository : GenericRepository<ReportImage>, IReportImageRepository
    {
        private readonly FitSwipeDbContext _context;
        public ReportImageRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
