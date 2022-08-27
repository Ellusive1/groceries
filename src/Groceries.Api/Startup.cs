using Groceries.Api.Data;
using Groceries.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Groceries.Api
{
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">Access configuration.</param>
        /// <param name="environment">Access environment.</param>
        public Startup(IConfiguration configuration, IHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        /// <summary>
        /// Gets configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Gets current environment.
        /// </summary>
        public IHostEnvironment Environment { get; }

        /// <summary>
        /// Configure services.
        /// </summary>
        /// <param name="services">ServiceCollection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped<GroceryService>();

            var connectionString = Configuration.GetConnectionString("Groceries");

            services.AddDbContext<GroceriesDbContext>(db => db
                .UseSqlServer(connectionString));

        }

        /// <summary>
        /// Configure pipeline.
        /// </summary>
        /// <param name="app">App.</param>
        /// <param name="env">Env.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
