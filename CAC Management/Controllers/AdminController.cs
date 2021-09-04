using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAC_Management.DataBase;
using CAC_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CAC_Management.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext db;

        [TempData]
        public string message { get; set; }
        public AdminController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RoutineIndex(st_routine routine)
        {

            return View(db.student_routine.ToList());
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin model)
        {
            var i = db.Admin.Where(x => x.Name == model.Name && x.Password == model.Password).FirstOrDefault();
            if (i != null)
            {
                ViewBag.Login = "Succeecful";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Login = "User Name or Password Invalid!!!";
                return View();
            }
        }

        public IActionResult TeacherAttendance()
        {
            return View();
        }
    
        public IActionResult Routine()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Routine(st_routine routine)
        {

            if(!ModelState.IsValid)
            {
                return View();
                
            }
            db.student_routine.Add(routine);
            await db.SaveChangesAsync();
            message = "Routine Successfully Added";
            return RedirectToAction(nameof(RoutineIndex));
        }
        public async Task<IActionResult>delete(int? id)
        {
           var pid= await db.student_routine.FindAsync(id);
            if(pid==null)
            {
                return NotFound();
            }
            return View(pid);

        }

        [HttpPost]
        public async Task<IActionResult>delete(int id, st_routine routine)
        {
            var pid = await db.student_routine.FindAsync(id);
            db.student_routine.Remove(pid);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(RoutineIndex));
        }
        public IActionResult EditRoutine(int Id)
        {
            var l = db.student_routine.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditRoutine(st_routine f)
        {
            if (ModelState.IsValid)
            {
                st_routine t = new st_routine();
                t.ID = f.ID;
                t.day = f.day;
                t.time = f.time;
                t.sub = f.sub;
                t.instructor = f.instructor;
               

                db.student_routine.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("RoutineIndex");
        }
      
      
        public IActionResult StudentList()
        {
            var test = db.Student;
            var i = new List<Student>();
            foreach (var s in test)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.Address = s.Address;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Password = s.Password;
                /* t.TuitionFee = s.TuitionFee;
                 t.PayAmount = s.PayAmount;
                 t.DueAmount = s.DueAmount;
                 t.PaymentStatus = s.PaymentStatus;*/
                i.Add(t);
            }
            // ViewBag.msg = "Pay Your Due First";
            return View(i);
        }
        public IActionResult DeleteStudent(int Id)
        {
            var l = db.Result.Find(Id);
            db.Result.Remove(l);
            db.SaveChanges();
            return RedirectToAction("ResultView");
        }
        public IActionResult ResultView()
        {
            var test = db.Result;
            var i = new List<Result>();
            foreach (var f in test)
            {
                Result t = new Result();
                t.StudentId = f.StudentId;
                t.StudentName = f.StudentName;
                t.Subject = f.Subject;
                t.Marks = f.Marks;
                t.Performance = f.Performance;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult AddResult()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddResult(Result result)
        {

            if (!ModelState.IsValid)
            {
                if (result.Marks >= 90) result.Performance = "A";
                else if (result.Marks >= 80) result.Performance = "B";
                else if (result.Marks >= 70) result.Performance = "C";
                else if (result.Marks >= 60) result.Performance = "D";
                else result.Performance = "F";
                db.Result.Add(result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> delete(int id, Result result)
        {
            var pid = await db.Result.FindAsync(id);
            db.Result.Remove(pid);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(ResultView));
        }
    }
}