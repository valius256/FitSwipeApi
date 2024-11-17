
using FitSwipe.Shared.Dtos.Management;

namespace FitSwipe.BusinessLogic.Interfaces.Management
{
    public interface IAdminService
    {
        Task<GetDashboardStatDto> GetStatistic();
    }
}
