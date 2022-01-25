using Finest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Finest.Controllers
{
    public class FinestController : Controller
    {
        private static IList<FinestModel> finest = new List<FinestModel>();
        public ActionResult Index()
        {
            return View(finest);
        }

        // GET: FinestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new FinestModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FinestModel finestModel, IFormCollection collection)
        {
            finestModel.Id = finest.Count + 1;
            finest.Add(finestModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: FinestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinestController/Edit/5
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

        // GET: FinestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinestController/Delete/5
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
