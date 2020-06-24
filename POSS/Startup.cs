using System;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POSS.DataAccess.Context;
using POSS.Services.CartServices.Implementation;
using POSS.Services.CartServices.Interface;
using POSS.Services.DeliveryServices.Implementation;
using POSS.Services.DeliveryServices.Interface;
using POSS.Services.GroupService.Implementation;
using POSS.Services.GroupService.Interface;
using POSS.Services.Implementation;
using POSS.Services.Interfaces;
using POSS.Services.OrderServices.Implementation;
using POSS.Services.OrderServices.Interface;
using POSS.Services.PaymentService.Implementation;
using POSS.Services.PaymentService.Interface;
using POSS.Services.SubGroupServices.Implementation;
using POSS.Services.SubGroupServices.Interface;
using POSS.Services.TransactionService.Implementation;
using POSS.Services.TransactionService.Interface;

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
            services.AddControllersWithViews();
            services.AddResponseCompression();

            //Allow CORS from anywhere
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddResponseCompression();
            services.AddDbContext<POSSDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection"),
                    x => x.MigrationsAssembly("POSS.DataAccess")));


            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IGroupLogic, GroupLogic>();
            services.AddScoped<ISubGroupLogic, SubGroupLogic>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IDelivery, DeliveryService>();

            //Google Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = GoogleDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;

            }).AddGoogle(options =>
                {
                    options.ClientId = "1097296782942-vml6kenaj2tcb0oto7146fs1j7gthssu.apps.googleusercontent.com";
                    options.ClientSecret = "xHcXBVNZfpS1BUQ3Ejy0csbD";
                });
            services.AddMvc();

            //In-Memory
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });
            // Add framework services.

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true; // consent required
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true; // make the session cookie Essential
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(options => options.AllowAnyOrigin());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseResponseCompression();

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
