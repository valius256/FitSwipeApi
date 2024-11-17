
namespace FitSwipe.Shared.Dtos.Management
{
    public class GetDashboardStatDto
    {
        public double? TotalCommissionRevenue { get; set; }
        public double? TotalSubscriptionRevenue { get; set; }
        public double? ThisMonthSubscriptionRevenue { get; set; }
        public double? LastMonthSubscriptionRevenue { get; set; }
        public double? ThisMonthCommissionRevenue { get; set; }
        public double? LastMonthCommissionRevenue { get; set; }

        public int? TotalTransactions { get; set; }
        public int? ThisMonthTransactions { get; set; }
        public int? LastMonthTransactions { get; set; }
        public double? ThisMonthTransactionsValue { get; set; }
        public double? LastMonthTransactionsValue { get; set; }
        public double? TotalTransactionsValue { get; set; }

        public int? TotalUsers { get; set; }
        public int? ThisMonthTotalUsers { get; set; }
        public int? LastMonthTotalUsers { get; set; }
        public double? TotalUsersBalance { get; set; }
        public int? NumberOfTrainee { get; set; }
        public int? NumberOfPT { get; set; }
        public int? NumberOfBelow18 { get; set; }
        public int? NumberOfAge18To24 { get; set; }
        public int? NumberOfAge25To34 { get; set; }
        public int? NumberOfAge35To44 { get; set; }
        public int? NumberOfAge45To55 { get; set; }
        public int? NumberOfAgeAbove55 { get; set; }
        public int? NumberOfMale { get; set; }
        public int? NumberOfFemale { get; set; }
        public int? NumberOfOtherGender { get; set; }
    }
}
