using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumiSourceApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LumiSourceApi
{
    public class XLogoDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // need to check if extension already exists, otherwise swagger 
            // tries to re-add it and results in error  
            if (!swaggerDoc.Info.Extensions.ContainsKey("x-logo"))
                swaggerDoc.Info.Extensions.Add("x-logo", new OpenApiObject
            {
                {"url", new OpenApiString("https://www.petstore.com/assets/images/logo.png")},
                {"backgroundColor", new OpenApiString("#FFFFFF")},
                {"altText", new OpenApiString("PetStore Logo")}
            });
        }

    }
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
            //Scaffold-DbContext "Server=DESKTOP-G8VPMPS;Initial Catalog=Lumisource;User ID=demouser;Password=demouser1!" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models
            services.AddControllers();
            services.AddControllersWithViews(); //thsi middle ware is needed for mvc constollers
            string  ConnectionString = Configuration.GetConnectionString("lumi1");
            services.AddDbContext<LumisourceContext>(optons => optons.UseSqlServer(ConnectionString));

            //this portion can be commented 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LumiSource, LLC", Version = "v1" ,
                    Contact = new OpenApiContact
                    {
                        Name = "Web Page",
                        Email = string.Empty,
                        Url = new Uri("https://localhost:44360/")
                    } 
                    

                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lumi Source, LLC"));
                

            } 
            
            app.UseHttpsRedirection();

            app.UseRouting();
            //*{ these two middleware are used of web app specificall and not needed for APIs, but I am using this app for both so I added
            app.UseStaticFiles();
            app.UseRouting();
            //*}
            app.UseAuthorization();
            //for api call handler
              app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllers();
                  //for mvc controller call
                  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Default}/{action=Index}/{id?}");
              });
             
           /*
              app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Default}/{action=Index}/{id?}");
              }); 
             */
        }
    }
}
