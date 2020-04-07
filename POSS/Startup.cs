using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using POSS.DataAccess.Context;
using POSS.Services.GroupService.Implementation;
using POSS.Services.GroupService.Interface;
using POSS.Services.Implementation;
using POSS.Services.Interfaces;
using POSS.Services.SubGroupServices.Implementation;
using POSS.Services.SubGroupServices.Interface;

namespace POSS
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
            services.AddCors();
            services.AddControllers();

            //Allow CORS from anywhere
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddDbContext<POSSDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection"),
                    x => x.MigrationsAssembly("POSS.DataAccess")));
            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IGroupLogic, GroupLogic>();
            services.AddScoped<ISubGroupLogic, SubGroupLogic>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(options => options.AllowAnyOrigin());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
