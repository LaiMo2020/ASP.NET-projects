using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyInfo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDistributedMemoryCache();

            services.AddMvc();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  "default",
                 "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    "About",
                    "{action=About}",
                    defaults: new { controller = "Home", action = "About" }
                );
                endpoints.MapControllerRoute(
                    "Contact",
                    "{action=Contact}",
                    defaults: new { controller = "Home", action = "Contact" }
                );
                endpoints.MapControllerRoute(
                    "Projects",
                    "{action=Projects}",
                    defaults: new { controller = "Home", action = "Projects" }
                );
                endpoints.MapControllerRoute(
                    "Index",
                    "{action=Index}",
                    defaults: new { controller = "Home", action = "Index" }
                );
                endpoints.MapControllerRoute(
                     "FeverCheck",
                     "{action=FeverCheck}",
                    defaults: new { controller = "Doctor", action = "FeverCheck" }
                );
            });


        
        }
    }
}
