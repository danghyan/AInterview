using Accounts.Api.BL;
using Accounts.Api.EF;
using Accounts.Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Linq;

namespace Accounts.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CustomerDbContext>(builder =>
           builder.UseInMemoryDatabase("testDb").EnableSensitiveDataLogging());

            services.AddControllers();
            services.AddSingleton<IAccountProvider, AccountProvider>();
            services.AddSwaggerGen(opt => opt.SwaggerDoc("v1" ,
                new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title="Demo"
                }));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", " Api v1");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}