using Microsoft.OpenApi.Models;

namespace Diffrent.Practice.Concept.WebApi
{
    public class Startup(IConfiguration Configuration)
    {
        public IConfiguration Configuration { get; } = Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Diffrent.Practice.Concept.Api", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
        }
    }
}
