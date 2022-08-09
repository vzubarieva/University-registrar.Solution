using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly UniversityRegistrarContext _db;

        public DepartmentsController(UniversityRegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Department> model = _db.Departments.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department, int CourseId)
        {
            _db.Departments.Add(department);
            _db.SaveChanges();
            if (CourseId != 0)
            {
                _db.DepartmentCourses.Add(
                    new DepartmentCourse()
                    {
                        CourseId = CourseId,
                        DepartmentId = department.DepartmentId
                    }
                );
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisDepartment = _db.Departments
                .Include(department => department.JoinEntities)
                .ThenInclude(join => join.Course)
                .FirstOrDefault(department => department.DepartmentId == id);
            return View(thisDepartment);
        }

        public ActionResult Edit(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(
                department => department.DepartmentId == id
            );
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View(thisDepartment);
        }

        [HttpPost]
        public ActionResult Edit(Department department, int CourseId)
        {
            if (CourseId != 0)
            {
                _db.DepartmentCourses.Add(
                    new DepartmentCourse()
                    {
                        CourseId = CourseId,
                        DepartmentId = department.DepartmentId
                    }
                );
            }
            _db.Entry(department).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddCourse(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(
                department => department.DepartmentId == id
            );
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View(thisDepartment);
        }

        [HttpPost]
        public ActionResult AddCourse(Department department, int CourseId)
        {
            if (CourseId != 0)
            {
                _db.DepartmentCourses.Add(
                    new DepartmentCourse()
                    {
                        CourseId = CourseId,
                        DepartmentId = department.DepartmentId
                    }
                );
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
