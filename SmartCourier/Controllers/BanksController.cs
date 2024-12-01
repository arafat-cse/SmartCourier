using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCourier.Models;

namespace SmartCourier.Controllers
{
    public class BanksController : Controller
    {
        private readonly CourierDbContext _db;

        public BanksController(CourierDbContext db)
        {
            _db = db;
        }

        // GET: BanksController
        public IActionResult Index()
        {
            var banks = _db.Banks.Include(b => b.Companys).ToList();
            return View(banks);
        }
        public IActionResult Create()
        {
            ViewBag.Companys = _db.Companys
                .Select(c => new SelectListItem
                {
                    Value = c.companyId.ToString(), 
                    Text = c.companyName 
                })
                .ToList(); 

            return View();
        }
        // POST: BanksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bank bank)
        {
            if (ModelState.IsValid)
            {
                bank.createDate = DateTime.Now;
                _db.Banks.Add(bank);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Companys = _db.Companys.ToList();
            return View(bank);
        }


        // GET: Edit Bank
        public IActionResult Edit(int id)
        {
            var bank = _db.Banks.FirstOrDefault(b => b.bankId == id);
            if (bank == null)
            {
                return NotFound();
            }
            ViewBag.Companys = _db.Companys
                .Select(c => new SelectListItem
                {
                    Value = c.companyId.ToString(),
                    Text = c.companyName
                })
                .ToList();

            return View(bank);
        }

        // POST: Edit Bank
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Bank bank)
        {
            if (ModelState.IsValid)
            {
                var existingBank = _db.Banks.FirstOrDefault(b => b.bankId == bank.bankId);
                if (existingBank == null)
                {
                    return NotFound();
                }
                existingBank.companyId = bank.companyId;
                existingBank.address = bank.address;
                existingBank.accountNo = bank.accountNo;
                existingBank.branchName = bank.branchName;
                existingBank.createBy = bank.createBy;
                existingBank.createDate = bank.createDate;
                existingBank.updateBy = bank.updateBy;
                existingBank.updateDate = DateTime.Now; 
                existingBank.IsActive = bank.IsActive;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

          
            ViewBag.Companys = _db.Companys
                .Select(c => new SelectListItem
                {
                    Value = c.companyId.ToString(),
                    Text = c.companyName
                })
                .ToList();

            return View(bank);
        }

        // GET: Delete Confirmation
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var bank = _db.Banks.FirstOrDefault(b => b.bankId == id);

            if (bank == null)
            {
                return NotFound();
            }

            return View(bank); 
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var bank = _db.Banks.Find(id);

            if (bank == null)
            {
                return NotFound();
            }

            _db.Banks.Remove(bank);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
