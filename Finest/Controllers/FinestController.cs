using Finest.Models;
using Finest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Finest.Controllers
{
    public class FinestController : Controller
    {
        private readonly FinestService finestService;

        public FinestController(FinestService finestService)
        {
            this.finestService = finestService;
        }

        public IActionResult Index(CancellationToken cancellationToken)
        {
            return View(finestService.GetAll());
        }

        public IActionResult Details(int id, CancellationToken cancellationToken)
        {
            return View(finestService.Details(id));
        }

        public IActionResult Create()
        {
            return View(new FinestModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FinestModel finestModel, CancellationToken cancellationToken)
        {
            finestService.Create(finestModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id, CancellationToken cancellationToken)
        {
            return View(finestService.Details(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, FinestModel finestModel, CancellationToken cancellationToken)
        {
            finestService.Edit(id, finestModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id, CancellationToken cancellationToken)
        {
            return View(finestService.Details(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(FinestModel finest, CancellationToken cancellationToken)
        {
            finestService.Delete(finest.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
