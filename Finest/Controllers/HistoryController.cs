using Finest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Finest.Controllers
{
    public class HistoryController : Controller
    {
        private readonly FinestService finestService;

        public HistoryController(FinestService finestService)
        {
            this.finestService = finestService;
        }
        public IActionResult Index(CancellationToken cancellationToken)
        {
            return View(finestService.GetAllCompleted());
        }

        public ActionResult Details(int id, CancellationToken cancellationToken)
        {
            return View(finestService.Details(id));
        }
    }
}
