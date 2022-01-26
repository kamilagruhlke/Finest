using Finest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Finest.Controllers
{
    public class FinestController : Controller
    {
        private static IList<FinestModel> finests = new List<FinestModel>();
        public IActionResult Index(CancellationToken cancellationToken)
        {
            return View(finests);
        }

        public IActionResult Details(int id, CancellationToken cancellationToken)
        {
            return View(finests.FirstOrDefault( x => x.Id == id));
        }

        public IActionResult Create()
        {
            return View(new FinestModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FinestModel finestModel, CancellationToken cancellationToken)
        {
            finestModel.Id = finests.Count + 1;
            finests.Add(finestModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id, CancellationToken cancellationToken)
        {
            return View(finests.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, FinestModel finestModel, CancellationToken cancellationToken)
        {
            FinestModel finest = finests.FirstOrDefault(x => x.Id == id);
            finest.Name = finestModel.Name;
            finest.Description = finestModel.Description;
            finest.Date = finestModel.Date;
            finest.Completed = finestModel.Completed;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id, CancellationToken cancellationToken)
        {
            return View(finests.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, FinestModel finestModel, CancellationToken cancellationToken)
        {
            FinestModel finest = finests.FirstOrDefault(x => x.Id == id);
            finests.Remove(finest);

            return RedirectToAction(nameof(Index));
        }
    }
}
