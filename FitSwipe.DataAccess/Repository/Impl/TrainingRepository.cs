
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
                .Include(t => t.Slots)
                .Include(t => t.FeedbackImages)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<PagedResult<Training>> GetTrainings(PagingModel<QueryTrainingDto> pagingModel)
        {
            var query = _context.Trainings
                .Include(t => t.PT)
                .Include(t => t.Trainee)
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

            return await query.ToNewPagingAsync(page, limit);

        }
    }
}
