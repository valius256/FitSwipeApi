using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Slots;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class SlotRepository : GenericRepository<Slot>, ISlotRepository
    {
        private readonly FitSwipeDbContext _context;
        public SlotRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Slot> GetSlotDetailDtos(Guid slotId) => await _context.Slots.Include(s => s.Videos).FirstOrDefaultAsync(x => x.Id == slotId);

        public async Task<PagedResult<Slot>> GetSlots(PagingModel<QuerySlotDto> pagingModel)
        {
            var query = _context.Slots
                .AsQueryable();

            if (pagingModel.Filter != null)
            {
                if (pagingModel.Filter.CreateById != null)
                {
                    query = query.Where(s => s.CreateById == pagingModel.Filter.CreateById);
                }
                if (pagingModel.Filter.TrainingId.HasValue)
                {
                    query = query.Where(s => s.TrainingId == pagingModel.Filter.TrainingId);
                }
                if (pagingModel.Filter.Type.HasValue)
                {
                    query = query.Where(s => s.Type == pagingModel.Filter.Type);
                }
                if (pagingModel.Filter.StartTime.HasValue)
                {
                    query = query.Where(s => s.StartTime >= pagingModel.Filter.StartTime);
                }
                if (pagingModel.Filter.EndTime.HasValue)
                {
                    query = query.Where(s => s.EndTime <= pagingModel.Filter.EndTime);
                }
                if (pagingModel.Filter.RatingFrom != null)
                {
                    query = query.Where(s => s.Rating >= pagingModel.Filter.RatingFrom);
                }
                if (pagingModel.Filter.RatingTo != null)
                {
                    query = query.Where(s => s.Rating <= pagingModel.Filter.RatingTo);
                }
                if (pagingModel.Filter.IsFeedbacked.HasValue)
                {
                    query = query.Where(s => (s.Feedback != null) == pagingModel.Filter.IsFeedbacked);
                }
                if (pagingModel.Filter.PaymentStatus.Count > 0)
                {
                    query = query.Where(s => pagingModel.Filter.PaymentStatus.Contains((Shared.Enum.PaymentStatus)s.PaymentStatus));
                }
                if (pagingModel.Filter.Status.Count > 0)
                {
                    query = query.Where(s => pagingModel.Filter.Status.Contains((Shared.Enum.SlotStatus)s.Status));
                }

            }

            int limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            int page = pagingModel.Page > 0 ? pagingModel.Page : 1;
            return await query.ToNewPagingAsync(page, limit);
        }

    }
}
