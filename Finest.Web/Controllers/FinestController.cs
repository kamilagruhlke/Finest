using Finest.Models;
using Finest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Finest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinestController : ControllerBase
    {
        private readonly FinestService finestService;

        public FinestController(FinestService finestService)
        {
            this.finestService = finestService;
        }

        [HttpGet]
        public IActionResult GetAll(CancellationToken cancellationToken)
        {
            var finest = this.finestService.GetAll();
            return Ok(finest);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetails(int id, CancellationToken cancellationToken)
        {
            var details = this.finestService.Details(id);
            return Ok(details);
        }

        [HttpPost]
        public IActionResult Create(FinestModel finestModel, CancellationToken cancellationToken)
        {
            this.finestService.Create(finestModel);
            return Ok(finestModel);
        }

        [HttpPut]
        public IActionResult Update(int id, FinestModel finestModel, CancellationToken cancellationToken)
        {
            this.finestService.Edit(id, finestModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, CancellationToken cancellationToken)
        {
            finestService.Delete(id);
            return NoContent();
        }
    }
}
