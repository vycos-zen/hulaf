using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using HULAF.DataAccess.Context;
//using HULAF.WebApi.Mapping;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HULAF.Application.Mapping;

namespace HULAF.WebApi
{
    public class Startup
    {
        private string hulafContextConnectionString = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(HulafMapperConfiguration.GetConfiguration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<HULAFContext>(options => options.UseNpgsql(hulafContextConnectionString));

            services.AddOpenApiDocument(c =>
            {
                c.DocumentName = "v1";
                c.Title = "HULAF API";
                c.Version = "OpenAPI 3.0";
                c.Description = "The application aids the reunion of people who have been separated";
            });

            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                hulafContextConnectionString = Configuration["HulafDatabaseLocal:ConnectionString"];
            }
            else
            {
                app.UseHsts();
            }

            //TODO: add to kubernetes config ass well
            app.UseHealthChecks("/ready");

            app.UseMvc();
            app.UseSwagger(c =>
            {
                c.Path = "/swagger/v1/swagger.json";
            });
            app.UseSwaggerUi3();

            // app.UseHttpsRedirection();
        }
    }
}
