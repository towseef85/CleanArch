﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public CourseVM GetCourses()
        {
            return new CourseVM()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
