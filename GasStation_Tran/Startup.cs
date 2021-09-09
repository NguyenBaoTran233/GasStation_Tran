using GasStation_Tran.Data;
using GasStation_Tran.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran
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
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddScoped<IUser, userRepository>();  // nhớ liên kết Interface và repository như thế này 
            services.AddScoped<IDistrict, DistrictRepository>();
            services.AddScoped<IGasStationType, GasStationTypeRepository>();
            services.AddScoped<IGasStationFeedback, GasStationFeedbackRepository>();
            services.AddScoped<IGasStationList, GasStationListRepository>();
            services.AddScoped<IGasStationListFeedback, GasStationListFeedbackRepository>();
            services.AddScoped<IRating, RatingRepository>();
            services.AddScoped<IGasStationAdd, GasStationAddRepository>();
            services.AddScoped<IGasStationEdit, GasStationEditRepository>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDistributedMemoryCache();
            
            services.AddSession(config =>
            {
                config.Cookie.Name = "GasStation";
                config.IdleTimeout = new TimeSpan(0, 60, 0);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}/{id?}");
            });
        }
    }
}
