using Microsoft.AspNetCore.Mvc;
using SmartCourier.Models;

namespace SmartCourier.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CourierDbContext _db;

        public CompanyController(CourierDbContext db)
        {
            _db=db;
        }
        public ActionResult Index()
        {
            var companies = _db.Companys.ToList(); // Fetch all companies
            return View(companies);
        }

        // GET: CompanyController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: CompanyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _db.Companys.Add(company);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }
        // GET: CompanyController/Edit/5
        public IActionResult Edit(int id)
        {
            var company = _db.Companys.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: CompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Company company)
        {
            if (id != company.companyId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Companys.Update(company);
                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Unable to save changes: " + ex.Message);
                }
            }
            return View(company);
        }
        // GET: CompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            var company = _db.Companys.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var company = _db.Companys.Find(id);
            if (company != null)
            {
                _db.Companys.Remove(company);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        
    }
}
