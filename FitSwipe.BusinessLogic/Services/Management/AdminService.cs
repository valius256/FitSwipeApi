using FitSwipe.BusinessLogic.Interfaces.Management;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Dtos.Management;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Management
{
    public class AdminService : IAdminService
    {
        private readonly IUserServices _userService;
        private readonly ITransactionServices _transactionServices;

        public AdminService(IUserServices userService, ITransactionServices transactionServices)
        {
            _userService = userService;
            _transactionServices = transactionServices;
        }

        public async Task<GetDashboardStatDto> GetStatistic()
        {
            var transStatistic = await GetTransactionStatistic();
            var userStatistic = await GetUserStatistic();
            userStatistic.TotalTransactions = transStatistic.TotalTransactions;
            userStatistic.ThisMonthTransactions = transStatistic.ThisMonthTransactions;
            userStatistic.LastMonthTransactions = transStatistic.LastMonthTransactions;
            userStatistic.TotalTransactionsValue = transStatistic.TotalTransactionsValue;
            userStatistic.ThisMonthTransactionsValue = transStatistic.ThisMonthTransactionsValue;
            userStatistic.LastMonthTransactionsValue = transStatistic.LastMonthTransactionsValue;
            userStatistic.TotalCommissionRevenue = transStatistic.TotalCommissionRevenue;
            userStatistic.ThisMonthCommissionRevenue = transStatistic.ThisMonthCommissionRevenue;
            userStatistic.LastMonthCommissionRevenue = transStatistic.LastMonthCommissionRevenue;
            userStatistic.TotalSubscriptionRevenue = transStatistic.TotalSubscriptionRevenue;
            userStatistic.ThisMonthSubscriptionRevenue = transStatistic.ThisMonthSubscriptionRevenue;
            userStatistic.LastMonthSubscriptionRevenue = transStatistic.LastMonthSubscriptionRevenue;
            return userStatistic;
        }

        private async Task<GetDashboardStatDto> GetTransactionStatistic()
        {
            return await _transactionServices.GetGeneralStatistic();
        }

        private async Task<GetDashboardStatDto> GetUserStatistic()
        {
            return await _userService.GetUserStatistic();
        }
    }
}
