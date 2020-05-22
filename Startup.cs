using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CaoLendario.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CaoLendario
{
    public class Startup
    {
        //o método contrutor recebe a configuração de dados carregada de appsettings.json
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        //Este metodo é usado para preparar os objetos compartilhados que serão usados
        //durante a aplicação.Este compartilhamento é chamdo de Injeção de
        //Dependência.Por exemplo, quando um banco de dados depende das definições
        //de um modelo para ser criado.
        public void ConfigureServices(IServiceCollection services)
        {
            //configura os serviços oferecidos pela Entity Framework Core para a classe contexto do banco de dados
            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(Configuration["Data:SportStoreProdutos:ConnectionString"]));
            //Associa o Repositório EFProdutoRepositorio à interface IProdutoRepositorio
            //services.AddTransient<IProdutoRepositorio, EFProdutoRepositorio>();
            //services.AddTransient<IFabricanteRepositorio, EFFabricanteRepositorio>();
            //habilita o ASP.NET Core
            services.AddMvc();
        }

        //Este metodo é usado para preparar os componentes que recebem e processam
        //requisições HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Mostra detalhes das exceções que ocorrem na aplicação.
                app.UseDeveloperExceptionPage();
            }
            // Adiciona uma mensagem de resposta HTTP, como por exemplo 404 Not Found Responses.
            app.UseStatusCodePages();
            // habilita o suporte para arquivos contidos em wwwroot, como css e javascript
            app.UseStaticFiles();
            app.UseRouting();

            //definimos que a rota default será definida pela
            //invocação da action List que está no controller Produto.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}",
                defaults: new { controller = "Animal", action = "List" });
            });
            //ativa a população do banco de dados quando a aplicação for iniciada          
            //SeedData.EnsurePopulated(app);
        }
    }
}