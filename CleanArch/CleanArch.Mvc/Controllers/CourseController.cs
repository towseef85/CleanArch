using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _icourseService;

        public CourseController(ICourseService icourseService)
        {
            _icourseService = icourseService;
        }
        public IActionResult Index()
        {
            CourseVM model = _icourseService.GetCourses();
            return View(model);
        }
    }
}
