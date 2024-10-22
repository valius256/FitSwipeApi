using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;
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
        public async Task<User?> GetUserDetailById(string id)
        {
            return await _context.Users
                .Include(u => u.UserTags).ThenInclude(ut => ut.Tag)
                .Include(u => u.TagsCreated)
                .Include(u => u.UserMedias)
                .Include(u => u.TrainingsInstructing.Where(t => t.Status == TrainingStatus.NotStarted || t.Status == TrainingStatus.OnGoing))
                .Include(u => u.TrainingsAttending.Where(t => t.Status == TrainingStatus.NotStarted || t.Status == TrainingStatus.OnGoing))
                .FirstOrDefaultAsync(s => s.FireBaseId == id);
        }

        public async Task<User?> GetUserWithTagsById(string id)
        {
            return await _context.Users
                .Include(u => u.UserTags).ThenInclude(ut => ut.Tag)
                .FirstOrDefaultAsync(s => s.FireBaseId == id);
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
        public async Task<PagedResult<User>> GetMatchedPTOrdered(GetUserWithTagDto user, int page, int limit)
        {
            double sameGenderScore = (user.Tags.Any(t => t.SpecialTag == SpecialTag.SameGender)) ? 20 : 0;
            double diffGenderScore = (user.Tags.Any(t => t.SpecialTag == SpecialTag.DifferentGender)) ? 20 : 0;

            var tagIds = user.Tags.Select(t => t.Id).ToList();
            const double EarthRadius = 6371; // Earth radius in kilometers
            var random = new Random();
            var query = _context.Users
                .Include(u => u.TrainingsInstructing)
                .Include(u => u.UserTags)
                    .ThenInclude(ut => ut.Tag)
                .Where(u => u.Role == Role.PT && !u.TrainingsInstructing.Any(t => t.TraineeId == user.FireBaseId))
                .Select(u => new UserWithMatchScore
                {
                    //Some math that calculate distance of 2 points in the globe
                    User = u,
                    MatchScore = u.UserTags.Count(ut => tagIds.Contains(ut.TagId))
                    + ((u.Gender == user.Gender) ? sameGenderScore : 0)
                    + ((u.Gender != user.Gender) ? diffGenderScore : 0)
                    + (u.PTRating ?? 0) * 3
                    + ((u.SubscriptionLevel ?? 0) * 10)
                    + (user.Latitude.HasValue && user.Longitude.HasValue && u.Latitude.HasValue && u.Longitude.HasValue
                        ? (
                        2 * EarthRadius *
                            Math.Asin(Math.Sqrt(
                            Math.Pow(Math.Sin((Math.PI / 180) * (u.Latitude.Value - user.Latitude.Value) / 2), 2) +
                            Math.Cos((Math.PI / 180) * user.Latitude.Value) * Math.Cos((Math.PI / 180) * u.Latitude.Value) *
                            Math.Pow(Math.Sin((Math.PI / 180) * (u.Longitude.Value - user.Longitude.Value) / 2), 2)
                        ))
                )
                : 0)
                })
                .OrderByDescending(u => u.MatchScore)
                .AsQueryable();

            limit = limit > 0 ? limit : 10;
            page = page > 0 ? page : 1;


            // If necessary, convert the result into PagedResult<User>
            var queryResult = await query.ToNewPagingAsync(page, limit);// Adjust this line if needed
            return new PagedResult<User>
            {
                Errors = queryResult.Errors,
                Items = queryResult.Items.Select(u => u.User).ToList(),
                Limit = queryResult.Limit,
                Page = queryResult.Page,
                Total = queryResult.Total
            };
        }

        // SQL-Translatable Haversine distance calculation in LINQ
        //private double CalculateDistanceInQuery(double lat1, double lon1, double lat2, double lon2)
        //{
        //    const double R = 6371; // Radius of Earth in kilometers

        //    double lat = ToRadians(lat2 - lat1);
        //    double lon = ToRadians(lon2 - lon1);

        //    double a = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
        //               Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
        //               Math.Sin(lon / 2) * Math.Sin(lon / 2);

        //    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        //    return R * c; // Distance in kilometers
        //}

        // Converts degrees to radians
        

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
                    query = query.Where(u => u.Job != null && u.Job.Contains(queryUserDto.Job));
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

        public async Task<double?> GetNewRatingOfPT(string userId)
        {
            return await _context.Trainings.Where(t => t.Rating != null && t.PTId == userId).AverageAsync(t => t.Rating);
        }
    }
    public class UserWithMatchScore
    {
        public User User { get; set; } = default!;
        public double MatchScore { get; set; }

    }
}
