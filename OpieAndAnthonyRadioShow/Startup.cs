using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpieAndAnthonyRadioShow.Data;
using OpieAndAnthonyRadioShow.Services;

namespace OpieAndAnthonyRadioShow
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Injecting our DB to our services.
            services.AddDbContext<OpieAndAnthonyRadioShowDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // DefaultConnection is the name I gave our connectionstring in the app.json

            services.AddScoped<IRadioShow, RadioShowService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=RadioShow}/{action=Index}/{id?}");
            });
        }
    }
}
