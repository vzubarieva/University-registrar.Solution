using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
    public class StudentsController : Controller
    {
        private readonly UniversityRegistrarContext _db;

        public StudentsController(UniversityRegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, int CorseId)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            if (CourseId != 0)
            {
                _db.CourseStudent.Add(
                    new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId }
                );
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student thisStudent = _db.Students
                .Include(student => student.JoinEntities)
                .ThenInclude(join => join.Course)
                .FirstOrDefault(student => student.StudentId == id);
            return View(thisStudent);
        }

        //         public ActionResult Edit(int id)
        //         {
        //             var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        //             ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
        //             return View(thisCuisine);
        //         }

        //         [HttpPost]
        //         public ActionResult Edit(Cuisine cuisine)
        //         {
        //             _db.Entry(cuisine).State = EntityState.Modified;
        //             _db.SaveChanges();
        //             return RedirectToAction("Index");
        //         }

        //         public ActionResult Delete(int id)
        //         {
        //             var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        //             return View(thisCuisine);
        //         }

        //         [HttpPost, ActionName("Delete")]
        //         public ActionResult DeleteConfirmed(int id)
        //         {
        //             var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        //             _db.Cuisines.Remove(thisCuisine);
        //             _db.SaveChanges();
        //             return RedirectToAction("Index");
        //         }
    }
}
