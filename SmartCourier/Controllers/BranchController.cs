using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartCourier.Models;

namespace SmartCourier.Controllers
{
    public class BranchController : Controller
    {
        private readonly CourierDbContext _db;

        public BranchController(CourierDbContext db)
        {
            _db=db;
        }

        // GET: BranchController
        public IActionResult Index()
        {
            var branches = _db.Branches.ToList();
            return View(branches);
        }


        // GET: BranchController/Create
        // GET: Branch/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Branch/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                branch.createDate = DateTime.Now;
                _db.Branches.Add(branch);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(branch);
        }

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BranchController/Edit/5
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

        // GET: BranchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BranchController/Delete/5
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
