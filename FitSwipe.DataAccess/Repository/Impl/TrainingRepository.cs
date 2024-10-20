
using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Trainings;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class TrainingRepository : GenericRepository<Training>, ITrainingRepository
    {
        private readonly FitSwipeDbContext _context;
        public TrainingRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Training?> GetTrainingById(Guid id)
        {
            return await _context.Trainings
                .Include(t => t.PT)
                .Include(t => t.Trainee)
                .Include(t => t.Slots).ThenInclude(s => s.Videos)
                .Include(t => t.FeedbackImages)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<PagedResult<Training>> GetFeedbackTrainingOfPT(string userId, int limit, int page)
        {
            var query = _context.Trainings
                .Where(t => t.PTId == userId && (t.Rating != null || t.Feedback != null) && t.Status == Shared.Enum.TrainingStatus.Finished)
                .AsQueryable();

            limit = limit > 0 ? limit : 10;
            page = page > 0 ? page : 1;

            return await query
                .Include(t => t.FeedbackImages)
                .Include(t => t.Trainee)
                .OrderByDescending(t => t.CreatedDate)
                .ToNewPagingAsync(page, limit);

        }
        public async Task<PagedResult<Training>> GetTrainings(PagingModel<QueryTrainingDto> pagingModel)
        {
            var query = _context.Trainings
                .AsQueryable();

            if (pagingModel.Filter != null)
            {
                if (pagingModel.Filter.TrainingStatuses.Count > 0)
                {
                    query = query.Where(t => pagingModel.Filter.TrainingStatuses.Contains(t.Status));
                }
                if (pagingModel.Filter.PTId != null)
                {
                    query = query.Where(t => pagingModel.Filter.PTId == t.PTId);
                }
                if (pagingModel.Filter.TraineeId != null)
                {
                    query = query.Where(t => pagingModel.Filter.TraineeId == t.TraineeId);
                }
            }
            int limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            int page = pagingModel.Page > 0 ? pagingModel.Page : 1;

            return await query.Include(t => t.PT)
                .Include(t => t.Trainee).ToNewPagingAsync(page, limit);

        }
        public async Task<GetTrainingOverviewDto?> GetTrainingOverview(Guid id)
        {
            return await _context.Trainings
               .Where(t => t.Id == id)
               .Include(t => t.Slots)
               .Select(t => new GetTrainingOverviewDto
               {
                   StartTime = t.Slots.OrderBy(s => s.StartTime).Select(s => (DateTime?)s.StartTime).FirstOrDefault(),
                   EndTime = t.Slots.OrderByDescending(s => s.EndTime).Select(s => (DateTime?)s.EndTime).FirstOrDefault(),
                   TotalDuration = t.Slots.Sum(s => (int)(s.EndTime - s.StartTime).TotalHours), // Calculate duration in hours
                   TotalSlots = t.Slots.Count()
               })
               .FirstOrDefaultAsync();

        }
    }
}
