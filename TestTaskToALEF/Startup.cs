using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Mappers;
using TestTaskToALEF.Models;
using TestTaskToALEF.Services;
using TestTaskToALEF.Validations;

namespace TestTaskToALEF
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
            //Fluent Validation
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IValidator<Model>, ModelValidator>();

            services.AddRazorPages();

            var connectionString = Configuration
                .GetConnectionString("DefaultConnection");//Getting Connection string
            services.AddDbContext<ModelContext>(options 
                => options.UseMySql(connectionString));

            services.AddScoped<IModelService, ModelService>();


            services.AddAutoMapper(typeof(MappingEntity));//adding mapper

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();


            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
