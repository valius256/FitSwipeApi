
using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        private readonly FitSwipeDbContext _context;
        public TagRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Tag>> GetPagedTags(QueryTagDto queryTagDto)
        {
            var query = _context.Tags.AsQueryable();

            if (queryTagDto != null)
            {
                if (queryTagDto.TagTypes.Count > 0)
                {
                    query = query.Where(t => queryTagDto.TagTypes.Contains(t.TagType));
                }
                if (queryTagDto.Name != null)
                {
                    query = query.Where(t => t.Name.Contains(queryTagDto.Name));
                }
                if (queryTagDto.CreateById != null)
                {
                    query = query.Where(t => t.CreateById == queryTagDto.CreateById);
                }
                if (queryTagDto.CreatedDateFrom.HasValue)
                {
                    query = query.Where(t => t.CreatedDate >= queryTagDto.CreatedDateFrom);
                }
                if (queryTagDto.CreatedDateTo.HasValue)
                {
                    query = query.Where(t => t.CreatedDate <= queryTagDto.CreatedDateFrom);
                }
            }
            return await query.ToListAsync();
        }
    }
}
