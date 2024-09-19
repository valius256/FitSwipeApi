using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Users;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly FitSwipeDbContext _context;
        public UserRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        //public async Task<List<User>> GetUsers(QueryUserDto queryUserDto)
        //{
        //    var query = _context.Users.AsQueryable();
        //    query = GetFilterUserQuery(query, queryUserDto);
        //    return await query.ToListAsync();
        //}
        public async Task<PagedResult<User>> GetUsersPaged(PagingModel<QueryUserDto> pagingModel)
        {
            var query = _context.Users.AsQueryable();
            query = GetFilterUserQuery(query, pagingModel.Filter);
            int limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            int page = pagingModel.Page > 0 ? pagingModel.Page : 1;
            return await query.ToNewPagingAsync(page, limit);
        }

        public async Task<PagedResult<User>> GetUsersPagedWithTags(PagingModel<QueryUserDto> pagingModel)
        {
            var query = _context.Users
                .Include(u => u.UserTags)
                    .ThenInclude(ut => ut.Tag)
                .AsQueryable();

            query = GetFilterUserQuery(query, pagingModel.Filter);
            int limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            int page = pagingModel.Page > 0 ? pagingModel.Page : 1;
            return await query.ToNewPagingAsync(page, limit);
        }

        public async Task<PagedResult<User>> GetMatchedPTOrdered(List<Guid> tagIds, int page, int limit)
        {
            var query = _context.Users
                .Include(u => u.UserTags)
                    .ThenInclude(ut => ut.Tag)
                .OrderByDescending(u =>
                    u.UserTags.Where(ut => tagIds.Contains(ut.TagId)).ToList().Count)
                .AsQueryable();

            limit = limit > 0 ? limit : 10;
            page = page > 0 ? page : 1;
            return await query.ToNewPagingAsync(page, limit);
        }

        private IQueryable<User> GetFilterUserQuery(IQueryable<User> query, QueryUserDto queryUserDto)
        {
            #region filter
            if (queryUserDto != null)
            {
                if (queryUserDto.UserName != null)
                {
                    query = query.Where(u => u.UserName.Contains(queryUserDto.UserName));
                }
                if (queryUserDto.Email != null)
                {
                    query = query.Where(u => u.UserName.Contains(queryUserDto.Email));
                }
                if (queryUserDto.Phone != null)
                {
                    query = query.Where(u => u.UserName.Contains(queryUserDto.Phone));
                }
                if (queryUserDto.Job != null)
                {
                    query = query.Where(u => u.Job.Contains(queryUserDto.Job));
                }
                if (queryUserDto.Ward != null)
                {
                    query = query.Where(u => u.Ward.Contains(queryUserDto.Ward));
                }
                if (queryUserDto.City != null)
                {
                    query = query.Where(u => u.Ward.Contains(queryUserDto.City));
                }
                if (queryUserDto.District != null)
                {
                    query = query.Where(u => u.District.Contains(queryUserDto.District));
                }
                if (queryUserDto.Street != null)
                {
                    query = query.Where(u => u.Ward.Contains(queryUserDto.Street));
                }
                if (queryUserDto.Bio != null)
                {
                    query = query.Where(u => u.Bio != null && u.Bio.Contains(queryUserDto.Bio));
                }
                if (queryUserDto.WeightFrom.HasValue)
                {
                    query = query.Where(u => u.Weight >= queryUserDto.WeightFrom);
                }
                if (queryUserDto.WeightTo.HasValue)
                {
                    query = query.Where(u => u.Weight <= queryUserDto.WeightTo);
                }
                if (queryUserDto.HeightFrom.HasValue)
                {
                    query = query.Where(u => u.Height >= queryUserDto.HeightFrom);
                }
                if (queryUserDto.HeightTo.HasValue)
                {
                    query = query.Where(u => u.Height <= queryUserDto.HeightTo);
                }
                if (queryUserDto.DateOfBirthFrom.HasValue)
                {
                    query = query.Where(u => u.DateOfBirth >= queryUserDto.DateOfBirthFrom);
                }
                if (queryUserDto.DateOfBirthTo.HasValue)
                {
                    query = query.Where(u => u.DateOfBirth <= queryUserDto.DateOfBirthTo);
                }
                if (queryUserDto.UpdatedDateFrom.HasValue)
                {
                    query = query.Where(u => u.UpdatedDate >= queryUserDto.UpdatedDateFrom);
                }
                if (queryUserDto.UpdatedDateTo.HasValue)
                {
                    query = query.Where(u => u.UpdatedDate <= queryUserDto.UpdatedDateTo);
                }
                if (queryUserDto.CreatedDateFrom.HasValue)
                {
                    query = query.Where(u => u.UpdatedDate >= queryUserDto.CreatedDateFrom);
                }
                if (queryUserDto.CreatedDateTo.HasValue)
                {
                    query = query.Where(u => u.UpdatedDate <= queryUserDto.CreatedDateTo);
                }
                if (queryUserDto.Genders.Count > 0)
                {
                    query = query.Where(u => queryUserDto.Genders.Contains(u.Gender));
                }
                if (queryUserDto.Roles.Count > 0)
                {
                    query = query.Where(u => queryUserDto.Roles.Contains(u.Role));
                }
                if (queryUserDto.RecordStatuses.Count > 0)
                {
                    query = query.Where(u => queryUserDto.RecordStatuses.Contains(u.RecordStatus));
                }
                if (queryUserDto.Statuses.Count > 0)
                {
                    query = query.Where(u => queryUserDto.Statuses.Contains(u.Status));
                }
            }

            #endregion
            return query;
        }
    }
}
