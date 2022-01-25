using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using web_api.Models;
using web_api.Context;
using web_api.Controllers.Models;
using web_api.Interfaces;
using web_api.Repositories;

namespace web_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            string con = "Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=spcapi;Integrated Security=True;";
            services.AddScoped<TovarInterface, TovarRepository>();
            services.AddScoped<ProdajaInterface, ProdajaRepository>();
            services.AddScoped<SotrydnikInterface, SotrydnikRepository>();
            services.AddScoped<DoljnostInterface, DoljnostRepository>();
            // устанавливаем контекст данных
            services.AddDbContext<MainContext>(options => options.UseSqlServer(con));

            services.AddControllers(); // используем контроллеры без представлений
        }
        public void Configure(IApplicationBuilder app)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // подключаем маршрутизацию на контроллеры
            });
        }
    }
}
