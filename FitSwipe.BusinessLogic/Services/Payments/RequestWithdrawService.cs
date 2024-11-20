
using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.RequestWithdraw;
using FitSwipe.Shared.Exceptions;
using Mapster;
using System.Collections.Generic;

namespace FitSwipe.BusinessLogic.Services.Payments
{
    public class RequestWithdrawService : IRequestWithdrawService
    {
        private readonly IRequestWithdrawRepository _requestWithdrawRepository;
        private readonly ITransactionServices _transactionServices;
        private readonly IUserServices _userServices;

        public RequestWithdrawService(IRequestWithdrawRepository requestWithdrawRepository, IUserServices userServices, ITransactionServices transactionServices)
        {
            _requestWithdrawRepository = requestWithdrawRepository;
            _userServices = userServices;
            _transactionServices = transactionServices;
        }

        public async Task<GetRequestWithdrawDto> CreateRequestWithdraw(CreateRequestWithdrawDto createRequestWithdrawDto, string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);

            if (user.Balance < createRequestWithdrawDto.Amount)
            {
                throw new BadRequestException("Insuffcient Balance");
            }

            var requestWithdraw = createRequestWithdrawDto.Adapt<RequestWithdraw>();
            requestWithdraw.UserId = userId;

            await _userServices.UpdateUserBalance(userId, -requestWithdraw.Amount);
            var createdTransaction = await _transactionServices.CreateTransactionAsync(new Shared.Dtos.Transactions.CreateTransactionDtos
            {
                TranscationCode = DateTime.UtcNow.Ticks.ToString(),
                UserFireBaseId = userId,
                Amount = requestWithdraw.Amount,
                Description = "Rút tiền tài khoản",
                Method = Shared.Enum.TransactionMethod.Balance,
                Type = Shared.Enum.TransactionType.Withdrawal
            });
            requestWithdraw.TransactionCode = createdTransaction.TranscationCode;
            var addedRequest = await _requestWithdrawRepository.AddAsync(requestWithdraw);
            return addedRequest.Adapt<GetRequestWithdrawDto>();
        }

        public async Task DeleteRequestWithdraw(Guid id, string userId)
        {
            var existedUser = await _userServices.GetUserByIdRequiredAsync(userId);
            var existedRequest = await GetRequestWithdrawRequiredById(id);
            if (existedUser.FireBaseId != existedRequest.UserId)
            {
                throw new BadRequestException("You do not have permission to do this function");
            }
            await _requestWithdrawRepository.DeleteAsync(id);
            if (existedRequest.TransactionCode != null)
            {
                await _transactionServices.UpdateTransactionStatus(long.Parse(existedRequest.TransactionCode), Shared.Enum.TransactionStatus.Canceled);
            }
        }

        public async Task<PagedResult<GetRequestWithdrawDto>> GetAllRequestWithdraw(int limit, int page)
        {
            var result = await _requestWithdrawRepository.GetRequestWithdrawPagedAsync(new PagingModel<QueryRequestWithdrawDto>
            {
                Limit = limit,
                Page = page
            });
            return result.Adapt<PagedResult<GetRequestWithdrawDto>>();
        }

        public async Task<PagedResult<GetRequestWithdrawDto>> GetRequestWithdrawOfUser(string userId, int limit, int page)
        {
            var existedUser = await _userServices.GetUserByIdRequiredAsync(userId);
            var result = await _requestWithdrawRepository.GetRequestWithdrawPagedAsync(new PagingModel<QueryRequestWithdrawDto>
            {
                Limit = limit,
                Page = page,
                Filter = new QueryRequestWithdrawDto { UserId = userId }
            });
            return result.Adapt<PagedResult<GetRequestWithdrawDto>>();
        }

        public async Task<GetRequestWithdrawDto> GetRequestWithdrawRequiredById(Guid id)
        {
            var result = await _requestWithdrawRepository.FindOneWithNoTrackingAsync(s => s.Id == id);
            if (result == null)
            {
                throw new DataNotFoundException("Request not found");
            }
            return result.Adapt<GetRequestWithdrawDto>();
        }

        public async Task<GetRequestWithdrawDto> UpdateRequestWithdraw(UpdateRequestWithdrawDto updateRequestWithdrawDto, string userId)
        {
            if (updateRequestWithdrawDto.Status == Shared.Enum.RequestStatus.Pending)
            {
                throw new BadRequestException("Can not update the request to pending status again");
            }

            await _userServices.GetUserByIdRequiredAsync(userId);
            var requestWithdraw = await GetRequestWithdrawRequiredById(updateRequestWithdrawDto.Id);
            
            requestWithdraw.OperatorMessage = updateRequestWithdrawDto.OperatorMessage;
            requestWithdraw.Status = updateRequestWithdrawDto.Status;
            requestWithdraw.HandlerId = userId;
            requestWithdraw.UpdatedDate = DateTime.SpecifyKind(DateTime.UtcNow.AddHours(7),DateTimeKind.Utc);

            if (requestWithdraw.Status == Shared.Enum.RequestStatus.Rejected)
            {
                await _userServices.UpdateUserBalance(userId, requestWithdraw.Amount);
                await _transactionServices.CreateTransactionAsync(new Shared.Dtos.Transactions.CreateTransactionDtos
                {
                    TranscationCode = DateTime.UtcNow.Ticks.ToString(),
                    UserFireBaseId = userId,
                    Amount = requestWithdraw.Amount,
                    Description = "Hoàn tiền do thất bại",
                    Method = Shared.Enum.TransactionMethod.Balance,
                    Type = Shared.Enum.TransactionType.Deposit
                });
                if (requestWithdraw.TransactionCode != null)
                {
                    await _transactionServices.UpdateTransactionStatus(long.Parse(requestWithdraw.TransactionCode), Shared.Enum.TransactionStatus.Failed);
                }
            } else
            {
                if (requestWithdraw.TransactionCode != null)
                {
                    await _transactionServices.UpdateTransactionStatus(long.Parse(requestWithdraw.TransactionCode), Shared.Enum.TransactionStatus.Successed);
                }
            }

            await _requestWithdrawRepository.UpdateAsync(requestWithdraw.Adapt<RequestWithdraw>());
            return requestWithdraw.Adapt<GetRequestWithdrawDto>();
        }
    }
}
