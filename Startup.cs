
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CaoLendario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.EntityFrameworkCore.SqlServer;
namespace CaoLendario
{
    public class Startup
    {
        //o m�todo contrutor recebe a configura��o de dados carregada de appsettings.json
        public Startup(IConfiguration configuration) => 
            Configuration = configuration;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(Configuration["Data:CaoLendario:ConnectionString"]));
            services.AddTransient<IAnimalRepositorio, EFAnimalRepositorio>();
            services.AddTransient<IProcedimentosPosAdocaoRepositorio, EFProcedimentosPosAdocaoRepositorio>();
            services.AddTransient<IProcedimentosPreAdocaoRepositorio, EFProcedimentosPreAdocaoRepositorio>();
            services.AddMvc();                        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();

     
            app.UseEndpoints(endpoints =>
            {
             endpoints.MapControllerRoute(
             name: "default",
             pattern: "{controller}/{action}/{id?}",
             defaults: new { controller = "Animal", action = "List" });
            });
            //SeedData.EnsurePopulated(app);
        }
    }
}
