using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task12NetCoreBackEnd.DataBase;
using Task12NetCoreBackEnd.Models;
using Task12NetCoreBackEnd.Services.Interface;

namespace Task12NetCoreBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReport _report;

        public ReportController(IReport report)
        {
            _report = report;
        }

        [HttpGet("{date}")]
        public async Task<ActionResult<Report>> GetByDateAsync(DateTime date)
        {
            return await _report.GetByDateAsync(date);
        }

        [HttpGet("{dateFrom}&{dateTo}")]
        public async Task<ActionResult<Report>> GetBetweenDatesAsync(DateTime dateFrom, DateTime dateTo)
        {
            return await _report.GetBetweenDatesAsync(dateFrom, dateTo);
        }

    }
}
