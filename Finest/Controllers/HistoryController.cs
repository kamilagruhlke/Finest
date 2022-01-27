using Finest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        // GET: HistoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
