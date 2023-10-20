using Integracijski_Modul.Data;
using Integracijski_Modul.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace Integracijski_Modul
{
    public class Startup
    {
        public string ConnectionString { get; set; }
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnectionString");
        }

        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext...
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
            services.AddScoped<VideosService>();
            services.AddScoped<GenresService>();
            services.AddScoped<TagsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            AppDbInitializer.Seed(app);
        }
    }
}
