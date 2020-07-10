using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QulificationToolForCreditCard.Models;
using QulificationToolForCreditCard.Models.BAL;
using QulificationToolForCreditCard.Models.BAL.Interface;
using QulificationToolForCreditCard.Repository;
using QulificationToolForCreditCard.Repository.Interface;

namespace QulificationToolForCreditCard
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<CreditCardContext>(x => x.UseSqlServer(Configuration.GetConnectionString("CreditCardConnection")));
            services.AddScoped(p => new CreditCardContext(p.GetService<DbContextOptions<CreditCardContext>>()));
            services.AddScoped<ICalculateCreditCard, CalculateCreditCard>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICardDetailsRepository, CardDetailsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
           // app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Customer}/{action=Index}/{id?}");
            });
        }
    }
}
