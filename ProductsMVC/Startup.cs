﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ProductsMVC.Contracts;
using ProductsMVC.Models;

namespace ProductsMVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            // utilizado para asignar tipos abstractor separados uno por cada peticion
            // permite registrara un servicio con tiempo de vida scoped
            services.AddScoped<IRepository, Repository>();

            // se crean cada ves que son solicitados funciona para servicios ligeros
            // services.AddTransient()

            // singleton se implementa un unica ves
            // services.AddSingleton();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            // flujo de canalizacion de peticiones o pipeline
            // configuracion de rutas 
            app.UseMvc(routes => {
                routes.MapRoute("Default", "{Controller = Product}/{action = Index}/{id?}");
            });

        }
    }
}
