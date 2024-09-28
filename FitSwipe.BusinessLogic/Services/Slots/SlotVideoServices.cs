using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Slots;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Slots
{
    public class SlotVideoServices : ISlotVideoServices
    {
        private readonly ISlotVideoRepository _slotVideoRepository;

        public SlotVideoServices(ISlotVideoRepository slotVideoRepository)
        {
            _slotVideoRepository = slotVideoRepository;
        }

        public async Task<CreateSlotVideoDtos> AddSlotVideoAsync(SlotVideoDto slotVideos)
        {
            var slotVideoEntity = slotVideos.Adapt<SlotVideos>();
            if (slotVideoEntity == null)
            {
                throw new Exception("Slot video entity is null");
            }

            var createdEntity = await _slotVideoRepository.AddAsync(slotVideoEntity);
            var createdDto = createdEntity.Adapt<CreateSlotVideoDtos>();
            return createdDto;
        }
    }
}
