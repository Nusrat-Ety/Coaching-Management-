using CAC_Management.DataBase;
using CAC_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAC_Management.Controllers
{
    public class GuardianController : Controller
    {
        private readonly DataContext db;
        [BindProperty]
        public Guardian guardian { get; set; }
        public GuardianController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Guardian model)
        {
            var i = db.Guardian.Where(x => x.GuardianName == model.GuardianName && x.Password == model.Password).FirstOrDefault();
            if (i != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Login = "User Name or Password Invalid!!!";
                return View();
            }
        }
        public IActionResult GuardianAdd()
        {
            return View();
        }
        [HttpPost, ActionName("GuardianAdd")]
        public async Task<IActionResult> CreateGuardian()
        {
            if (ModelState.IsValid)
            {
                db.Add(guardian);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(GuardianList));
            }

            return View(guardian);

        }
        public IActionResult GuardianList()
        {
            var test = db.Guardian;
            var i = new List<Guardian>();
            foreach (var f in test)
            {
                Guardian t = new Guardian();
                t.GuardianId = f.GuardianId;
                t.GuardianName = f.GuardianName;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Password = f.Password;

                i.Add(t);
            }
            return View(i);
        }

        public IActionResult GuardianDetails(int Id)
        {
            var l = db.Guardian.Find(Id);
            return View(l);
        }

        public IActionResult DeleteGuardian(int Id)
        {
            var l = db.Guardian.Find(Id);
            db.Guardian.Remove(l);
            db.SaveChanges();
            return RedirectToAction("GuardianList");
        }
       
    }
}
