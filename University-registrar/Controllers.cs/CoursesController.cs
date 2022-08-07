using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
    public class CoursesController : Controller
    {
        private readonly UniversityRegistrarContext _db;

        public CoursesController(UniversityRegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Course> model = _db.Courses.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisCourse = _db.Courses
                .Include(course => course.JoinEntities)
                .ThenInclude(join => join.Student)
                .FirstOrDefault(course => course.CourseId == id);
            return View(thisCourse);
        }

        public ActionResult Edit(int id)
        {
            var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
            return View(thisCourse);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            _db.Entry(course).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //         public ActionResult Delete(int id)
        //         {
        //             var thisRestaurant = _db.Restaurants.FirstOrDefault(
        //                 restaurant => restaurant.RestaurantId == id
        //             );
        //             return View(thisRestaurant);
        //         }

        //         [HttpPost, ActionName("Delete")]
        //         public ActionResult DeleteConfirmed(int id)
        //         {
        //             var thisRestaurant = _db.Restaurants.FirstOrDefault(
        //                 restaurant => restaurant.RestaurantId == id
        //             );
        //             _db.Restaurants.Remove(thisRestaurant);
        //             _db.SaveChanges();
        //             return RedirectToAction("Index");
        //         }
    }
}
