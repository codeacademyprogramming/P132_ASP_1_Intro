using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAsp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    //throw new ArgumentNullException("argument null");
                //    await context.Response.WriteAsync("<h1>Hello World!</h1>");
                //});

                //endpoints.MapGet("/home", async context =>
                //{
                //    var obj = new { Name = "Hikmet", GroupNo = "132" };
                //    var objJson = System.Text.Json.JsonSerializer.Serialize(obj);
                //    await context.Response.WriteAsync(objJson);
                //});

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}"
                    );


                endpoints.MapControllerRoute(
                  name: "about",
                  pattern: "about-us",
                  defaults:new {controller="home",action="about"}
                  );

            });
        }
    }
}
