
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace SportStore
{
    public class Startup
    {
        //o método contrutor recebe a configuração de dados carregada de appsettings.json
        public Startup(IConfiguration configuration) => 
            Configuration = configuration;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration["Data:SportStoreProdutos:ConnectionString"]));
            services.AddTransient<IProdutoRepositorio, EFProdutoRepositorio>();
            services.AddTransient<IFabricanteRepositorio, EFFabricanteRepositorio>();
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
             defaults: new { controller = "Produto", action = "List" });
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
