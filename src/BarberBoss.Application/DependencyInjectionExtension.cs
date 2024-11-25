﻿using BarberBoss.Application.AutoMapper;
using BarberBoss.Application.Services.Delete;
using BarberBoss.Application.Services.GetAll;
using BarberBoss.Application.Services.GetById;
using BarberBoss.Application.Services.Register;
using BarberBoss.Application.Services.Reports.Excel;
using BarberBoss.Application.Services.Reports.Pdf;
using BarberBoss.Application.Services.Update;
using Microsoft.Extensions.DependencyInjection;

namespace BarberBoss.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }
        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterServiceUseCase, RegisterServiceUseCase>();
            services.AddScoped<IGetAllServiceUseCase, GetAllServiceUseCase>();
            services.AddScoped<IGetServiceByIdUseCase, GetServiceByIdUseCase>();
            services.AddScoped<IDeleteServiceUseCase, DeleteServiceUseCase>();
            services.AddScoped<IUpdateServiceUseCase, UpdateServiceUseCase>();
            services.AddScoped<IGenerateServicesReportExcelUseCase, GenerateServicesReportExcelUseCase>();
            services.AddScoped<IGenerateServicesReportPdfUseCase, GenerateServicesReportPdfUseCase>();
        }
    }
}
