﻿using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Users
{
    public interface IUserServices
    {
        Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos);
        Task<User> GetUserByIdRequired(string id);
        Task<PagedResult<GetUserDto>> GetUserPaged(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTags(PagingModel<QueryUserDto> pagingModel);
    }
}
