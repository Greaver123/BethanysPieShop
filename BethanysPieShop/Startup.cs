using AutoMapper;
using BethanysPieShop.DataSource;
using BethanysPieShop.DataSource.Repositories;
using BethanysPieShop.Mapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(config => config.AddProfile(new PieProfile()));
            services.AddDbContext<PieShopDbContext>(
                opt => opt.UseSqlServer(
                    _configuration.GetConnectionString("MSSQLConnection"))
                    );
            services.AddTransient<IPieRepository, SqlPieRepository>(); //every time new instance
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}"
                ));
           // app.UseMvcWithDefaultRoute();
        }
    }
}
