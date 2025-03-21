﻿using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Management;
using FitSwipe.Shared.Dtos.Transactions;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.BusinessLogic.Services.Transactions
{
    public class TransactionServices : ITransactionServices
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserServices _userServices;

        public TransactionServices(ITransactionRepository transactionRepository, IUserServices userServices)
        {
            _transactionRepository = transactionRepository;
            _userServices = userServices;
        }

        public async Task<GetTransactionWithUserDto> CreateTransactionAsync(CreateTransactionDtos createTransactionDtos)
        {

            var convertTransactionToListString = createTransactionDtos.SlotIds.ConvertAll(x => x.ToString());

            var transaction = new Transaction
            {
                TranscationCode = createTransactionDtos.TranscationCode,
                Method = createTransactionDtos.Method,
                Status = Shared.Enum.TransactionStatus.Pending,
                UserFireBaseId = createTransactionDtos.UserFireBaseId,
                Amount = createTransactionDtos.Amount,
                Description = createTransactionDtos.Description ?? "",
                CreatedDate = DateTime.UtcNow.AddHours(7),
                Type = createTransactionDtos.Type
            };

            // Create TransactionSlots for each SlotId
            foreach (var slotId in createTransactionDtos.SlotIds)
            {
                var transactionSlot = new TransactionSlot
                {
                    SlotId = slotId,
                    Transaction = transaction,
                    CreatedDate = DateTime.UtcNow
                };
                transaction.TransactionSlots.Add(transactionSlot);
            }

            await _transactionRepository.AddAsync(transaction);
            return transaction.Adapt<GetTransactionWithUserDto>();
        }

        public async Task<Transaction> GetTransactionByOrderCodeAsync(long orderCode)
        {
            var result = await _transactionRepository.FindOneWithNoTrackingAsync(t => t.TranscationCode == orderCode.ToString());
            if (result == null)
            {
                throw new DataNotFoundException("Transaction not found");
            }
            return result;
        }

        public async Task<PagedResult<GetTransactionWithUserDto>> GetTransactionsPageAsync(PagingModel<QueryTransactionDtos> pagedRequest, string userFirebaseId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userFirebaseId);

            var pagedResultTransactionEntity = await _transactionRepository.GetTransactionsPageAsync(pagedRequest, user);
            return pagedResultTransactionEntity.Adapt<PagedResult<GetTransactionWithUserDto>>();
        }
        public async Task UpdateTransactionStatus(long orderCode, TransactionStatus status)
        {
            var transaction = await GetTransactionByOrderCodeAsync(orderCode);
            transaction.Status = status;
            await _transactionRepository.UpdateAsync(transaction);
        }

        public async Task<GetDashboardStatDto> GetGeneralStatistic()
        {
            return await _transactionRepository.GetTransactionStatistic();
        }

    }
}
