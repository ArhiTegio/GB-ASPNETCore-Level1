using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Services;
using WebStore.Data;

namespace WebStore
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration Configuration) => this.Configuration = Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                //@"Data Source=(local)\MSSQLLocalDB; Database=WebStore; Persist Security Info=False; MultipleActiveResultSets=True; Trusted_Connection=True;"
                @"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=WebStore;
                Integrated Security=True;
                Pooling=False"
            ));

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //AddTransient - каждый раз будет создаваться экземпляр сервиса
            //AddScoped - один экземпляр на область видимости 
            //AddSingleton
            services.AddTransient<IEmployeesData, InMemoryEmplyeeData>();
            services.AddTransient<IProductData, InMemoryProductData>();

  
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider sManeger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.UseWelcomePage("/welcome");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/greetings", async context =>
                {
                    await context.Response.WriteAsync(Configuration["CustomGreetings"]);
                });

                endpoints.MapControllerRoute(
                    name: "default", 
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
