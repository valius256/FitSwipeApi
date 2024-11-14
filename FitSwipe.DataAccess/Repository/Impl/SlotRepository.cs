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

        //public async Task<Slot> GetSlotDetailDtos(Guid slotId) => await _context.Slots.Include(s => s.Videos).FirstOrDefaultAsync(x => x.Id == slotId);

        public async Task<PagedResult<Slot>> GetSlots(PagingModel<QuerySlotDto> pagingModel)
        {
            var query = _context.Slots
                .AsQueryable();

            if (pagingModel.Filter != null)
            {
                if (pagingModel.Filter.TraineeId != null)
                {
                    query = query.Include(s => s.Training).Where(s => s.Training != null && s.Training.TraineeId == pagingModel.Filter.TraineeId);
                }
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
                    query = query.Where(s => s.PaymentStatus != null && pagingModel.Filter.PaymentStatus.Contains(s.PaymentStatus.Value));
                }
                if (pagingModel.Filter.Status.Count > 0)
                {
                    query = query.Where(s =>  pagingModel.Filter.Status.Contains(s.Status));
                }
                if (pagingModel.Filter.Ids.Count > 0)
                {
                    query = query.Where(s => pagingModel.Filter.Ids.Contains(s.Id));
                }
                if (pagingModel.Filter.PTId != null)
                {
                    query = query.Where(s => s.CreateById == pagingModel.Filter.PTId || (s.Training != null && s.Training.PTId == pagingModel.Filter.PTId))
                        .Include(s => s.Training);
                }
            }

            int limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            int page = pagingModel.Page > 0 ? pagingModel.Page : 1;
            return await query.ToNewPagingAsync(page, limit);
        }
        public async Task<List<Slot>> GetUpcomingSlotsOfPT(string ptId, int limit)
        {
            var slots = await _context.Slots
                .Where(s => s.StartTime > DateTime.SpecifyKind(DateTime.UtcNow.AddHours(7), DateTimeKind.Utc) && s.Training != null 
                && s.Training.PTId == ptId && s.Status != Shared.Enum.SlotStatus.Pending && s.Status != Shared.Enum.SlotStatus.Disabled)
                .Include(s => s.Training)
                .OrderBy(s => s.StartTime)
                .Take(limit)
                .ToListAsync();

            foreach (var slot in slots)
            {
                if (slot?.Training != null)
                {
                    await _context.Entry(slot.Training)
                       .Reference(t => t.Trainee)
                       .LoadAsync();
                }
            }
            return slots;
        }
        public async Task<List<Slot>> GetAllDebtSlotsOfTrainee(string traineeId)
        {
            var slots = await _context.Slots
                .Where(s => s.PaymentStatus != Shared.Enum.PaymentStatus.Paid 
                 && s.Status != Shared.Enum.SlotStatus.Pending
                 && s.Status != Shared.Enum.SlotStatus.Disabled
                 && s.Training != null && s.Training.TraineeId == traineeId)
                .Include(s => s.Training)
                .ToListAsync();

            foreach(var slot in slots)
            {
                if (slot?.Training != null)
                {
                    await _context.Entry(slot.Training)
                       .Reference(t => t.PT)
                       .LoadAsync();
                }
            }
            return slots;
        }
        public async Task<Slot?> GetSlotByIdAsync(Guid guid)
        {
            var slot = await _context.Slots
                .Include(s => s.CreateBy)
                .Include(s => s.Training)
                .Include(s => s.TransactionSlots)
                .Include(s => s.Videos)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == guid);

            if (slot?.Training != null)
            {
                // Conditionally load the Trainee only if Training is not null
                await _context.Entry(slot.Training)
                    .Reference(t => t.Trainee)
                    .LoadAsync();
                await _context.Entry(slot.Training)
                   .Reference(t => t.PT)
                   .LoadAsync();
            }
            return slot;
        }

        public async Task<List<Slot>> GetSlotsOfTrainee(string traineeId)
        {
            return await _context.Slots
                .Include(s => s.Training)
                .Where(s => s.CreateById == traineeId && s.Status != Shared.Enum.SlotStatus.Disabled)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<List<Slot>> GetSlotsOfPT(string PTId)
        {
            return await _context.Slots
                .Include(s => s.Training)
                .Where(s => (s.CreateById == PTId || (s.Training != null && s.Training.PTId == PTId)) && s.Status != Shared.Enum.SlotStatus.Disabled)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<int> CountSlotVideoAsync(Guid slotId)
        {
            return await _context.Slots
                         .Where(s => s.Id == slotId)
                         .SelectMany(s => s.Videos)
                         .CountAsync();
        }
    }
}
