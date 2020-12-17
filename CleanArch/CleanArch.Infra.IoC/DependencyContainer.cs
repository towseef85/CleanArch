using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddScoped<IMediatRHandler, InMemoryBus>();
            service.AddScoped<ICourseService, CourseService>();
            service.AddScoped<ICourseRepository, CourseRepository>();
            service.AddScoped<UniversityDbContext>();
        }
    }
}
