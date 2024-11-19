using FitSwipe.BusinessLogic.Interfaces.Reports;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/reports")]
    public class ReportController : BaseController<ReportController>
    {
        private readonly IReportService _reportService;
        public ReportController(ILogger<ReportController> logger, IReportService reportService) : base(logger)
        {
            _reportService = reportService;
        }

        [HttpGet]
        [Authorize(Policy = "RequireOperatorRole")]
        public async Task<ActionResult<PagedResult<GetReportDto>>> GetPagedReport([FromQuery] PagingModel<QueryReportDto> query)
        {
            return Ok(await  _reportService.GetPagedReport(query));
        }
        [HttpGet("{id}")]
        [Authorize(Policy = "RequireOperatorRole")]
        public async Task<ActionResult<GetReportDetailDto>> GetReportById([FromRoute] Guid id)
        {
            return Ok(await _reportService.GetReportDetail(id));
        }
        [HttpPost]
        [Authorize(Policy = "RequiredPTOrTraineeRole")]
        public async Task<ActionResult<GetReportDto>> CreateReport([FromBody] CreateReportDto createReportDto)
        {
            return Ok(await _reportService.CreateReport(createReportDto, CurrentUserFirebaseId));
        }
        [HttpPut]
        [Authorize(Policy = "RequireOperatorRole")]
        public async Task<ActionResult<GetReportDto>> UpdateReport([FromBody] UpdateReportDto updateReportDto)
        {
            await _reportService.UpdateReport(updateReportDto);
            return NoContent();
        }
    }
}
