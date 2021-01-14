using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            NewMethod(services);
        }

        private static void NewMethod(IServiceCollection services)
        {
            NewMethod1(services);
        }

        private static void NewMethod1(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            NewMethod2(app);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller}/{action}");
            });
        }

        private static void NewMethod2(IApplicationBuilder app)
        {
            app.UseRouting();
        }
    }

    class IWebHostEnvironment
    {
    }
}