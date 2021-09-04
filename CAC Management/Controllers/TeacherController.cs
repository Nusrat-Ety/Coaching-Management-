using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAC_Management.DataBase;
using CAC_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace CAC_Management.Controllers
{
    public class TeacherController : Controller
    {
        private readonly DataContext db;
        [BindProperty]
        public Teacher teacher { get; set; }
        public TeacherController(DataContext context)
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
        public IActionResult Login(Teacher model)
        {
            var i = db.Teacher.Where(x => x.TeacherName == model.TeacherName && x.Password == model.Password).FirstOrDefault();
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

        public IActionResult t_Routine(string search)
        {
            var result = from m in db.student_routine
                         select m;

            if(!string.IsNullOrEmpty(search))
            {
                result = result.Where(s => s.instructor.Contains(search));
            }
            return View(result.ToList());
        }

     
        public IActionResult TeacherAdmission()
        {
            return View();
        }
        [HttpPost,ActionName("TeacherAdmission")]
        public async Task<IActionResult> CreateTeacher()
        {
            if(ModelState.IsValid)
            {
                db.Add(teacher);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(TeacherList));
            }

            return View(teacher);

        }

        public IActionResult TeacherList()
        {
            var test = db.Teacher;
            var i = new List<Teacher>();
            foreach (var f in test)
            {
                Teacher t = new Teacher();
                t.TeacherId = f.TeacherId;
                t.TeacherName = f.TeacherName;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Password = f.Password;
              
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult Search(int Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }

        public IActionResult TeacherSearch(int Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }

        public IActionResult TeacherDetails(int Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }
        public IActionResult EditTeacher(int Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditTeacher(Teacher f)
        {
            if (ModelState.IsValid)
            {
                Teacher t = new Teacher();
                t.TeacherId = f.TeacherId;
                t.TeacherName = f.TeacherName;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Password = f.Password;
               
                db.Teacher.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("TeacherList");
        }

        public IActionResult DeleteTeacher(int Id)
        {
            var l = db.Teacher.Find(Id);
            db.Teacher.Remove(l);
            db.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        
        public IActionResult DeleteStudent(int Id)
        {
            var l = db.Result.Find(Id);
            db.Result.Remove(l);
            db.SaveChanges();
            return RedirectToAction("ResultIndex");
        }
        public IActionResult ResultIndex()
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

        public IActionResult ResultAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResultAdd(Result result)
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
        public async Task<IActionResult> delete(int? id)
        {
            var pid = await db.Result.FindAsync(id);
            if (pid == null)
            {
                return NotFound();
            }
            return View(pid);

        }

        [HttpPost]
        public async Task<IActionResult> delete(int id, Result result)
        {
            var pid = await db.Result.FindAsync(id);
            db.Result.Remove(pid);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(ResultIndex));
        }
    }
}