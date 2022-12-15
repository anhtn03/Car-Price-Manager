using Microsoft.Extensions.Configuration;

namespace CarPriceApi
{
    public class Startup
    {
        private const string CorsPolicy = "ApiCorsPolicy";
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddHttpContextAccessor();

            services.AddCors(o => o.AddPolicy(CorsPolicy, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("X-Pagination");
            }));
        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment webHostEnvironment)
        {
            if(webHostEnvironment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();
            app.UseRouting();
        }
    }
}
