using Admin_Javni_Modul.Data;
using Admin_Javni_Modul.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();

            //Services configuration
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            //Authentication & Authorization
            app.UseAuthentication();
            app.UseAuthorization();

  

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Movies}/{action=Index}/{id?}");
            });

            //Seedanje baze

            AppDbInitializer.Seed(app);
        }
    }
}
