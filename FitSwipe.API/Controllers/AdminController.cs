using FitSwipe.BusinessLogic.Interfaces.Management;
using FitSwipe.Shared.Dtos.Management;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/admin")]
    [Authorize(Policy = "RequireOperatorRole")]
    public class AdminController : BaseController<AdminController>
    {
        private readonly IAdminService _adminService;
        public AdminController(ILogger<AdminController> logger, IAdminService adminService) : base(logger)
        {
            _adminService = adminService;
        }

        [HttpGet("statistic")]
        public async Task<ActionResult<GetDashboardStatDto>> GetStatistic()
        {
            return await _adminService.GetStatistic();
        }
    }
}
