using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.Data.mocks;
using Microsoft.Extensions.Configuration;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using Shop.Data;
using Microsoft.EntityFrameworkCore;

namespace Shop
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars,MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
            services.AddMvc(options=>options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();



            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("We are in Debug mode");
                });
            });
        }
    }
}
