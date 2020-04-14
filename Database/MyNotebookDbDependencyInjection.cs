using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public static class MyNotebookDbDependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<MyNotebookDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DatabaseConnection")));

            services.AddScoped<IMyNotebookDbContext>(provider => provider.GetService<MyNotebookDbContext>());

            return services;
        }
    }
}
