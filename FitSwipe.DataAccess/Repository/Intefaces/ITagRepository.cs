
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Dtos.Tags;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        Task<List<Tag>> GetPagedTags(QueryTagDto queryTagDto);
    }
}
