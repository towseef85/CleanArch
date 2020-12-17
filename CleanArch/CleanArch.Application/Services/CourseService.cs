using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatRHandler _bus;
        public CourseService(ICourseRepository courseRepository, IMediatRHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseVM course)
        {
            var createCourseCammand = new CreateCourseCommand(
                
                course.Name,
                course.Description,
                course.ImageUrl

                );
            _bus.SendCommand(createCourseCammand);
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
