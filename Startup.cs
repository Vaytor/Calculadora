using Calculadora.Model.Context;
using Calculadora.Services;
using Calculadora.Services.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Calculadora
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //Injeção de depedencias 
            services.AddScoped<IPersonService, PersonServiceImpl>();

            //Configuração para o banco de dados
            var connection = Configuration["MySqlConnection: MySqlConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
