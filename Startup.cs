using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {   
        public void ConfigureServices(IServiceCollection services)
        {
            // додає підтримку контроллерів та представлень
            services.AddControllersWithViews()
            //виставляємо сусісність з версією .netCore
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //!! Подрядок реєстрації middleware вкрай важливий


            // в процесі розробки нам вкрай важливо бачити детальну інформацію про помилки
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // використовує маршрутиризацію
            app.UseRouting();
            //підключає підтримку статичних файлів в застосунку(.css, .js, img і т.д.);
            app.UseStaticFiles();

            // реєструємо потрібні нам маршрути (ендпоінти)
            app.UseEndpoints(endpoints =>
            {
                //стандартний дефолтний маршрут для будь якогo aspNetCore застосунку
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
