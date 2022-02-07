using Finest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Finest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly FinestService finestService;

        public HistoryController(FinestService finestService)
        {
            this.finestService = finestService;
        }

        [HttpGet]
        public IActionResult GetAll(CancellationToken cancellationToken)
        {
            var finest = this.finestService.GetAllCompleted();
            return Ok(finest);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetails(int id, CancellationToken cancellationToken)
        {
            var finest = this.finestService.Details(id);
            return Ok(finest);
        }
    }
}
