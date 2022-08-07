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

        public ActionResult Details(int id)
        {
            var thisDepartment = _db.Departments
                .Include(department => department.JoinEntities)
                .ThenInclude(join => join.Course)
                .FirstOrDefault(department => department.DepartmentId == id);
            return View(thisDepartment);
        }
    }
}
