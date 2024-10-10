using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Exceptions;
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

        public async Task<GetSlotVideoDto> AddSlotVideoAsync(CreateSlotVideoDtos slotVideos)
        {
            var slotVideoEntity = slotVideos.Adapt<SlotVideos>();
            if (slotVideoEntity == null)
            {
                throw new Exception("Slot video entity is null");
            }

            var createdEntity = await _slotVideoRepository.AddAsync(slotVideoEntity);
            var createdDto = createdEntity.Adapt<GetSlotVideoDto>();
            return createdDto;
        }

        public async Task<List<GetSlotVideoDto>> AddRangeSlotVideoAsync(List<CreateSlotVideoDtos> slotVideos)
        {
            var mappedSlotVideos = slotVideos.Adapt<List<SlotVideos>>();

            var createdEntity = await _slotVideoRepository.AddRangeAsync(mappedSlotVideos);
            var createdDto = createdEntity.Adapt<List<GetSlotVideoDto>>();
            return createdDto;
        }

        public async Task DeleteSlotVideoAsync(Guid id)
        {
            var slotVideo = await _slotVideoRepository.GetByIdAsync(id);
            if (slotVideo == null)
            {
                throw new DataNotFoundException("Slot video not found");
            }
            await _slotVideoRepository.DeleteAsync(id);
        }
        public async Task DeleteRangeSlotVideoAsync(List<Guid> ids)
        {
            var deleteList = new List<SlotVideos>();
            foreach (var id in ids)
            {
                var slotVideo = await _slotVideoRepository.GetByIdAsync(id);
                if (slotVideo == null)
                {
                    throw new DataNotFoundException("Slot video not found");
                }
                deleteList.Add(slotVideo);
            }
           
            await _slotVideoRepository.DeleteRangeAsync(deleteList);
        }
    }
}
