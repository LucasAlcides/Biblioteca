using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Contexto;
using AlcidesMontadora.Repository;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlcidesMontadora
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

            var ConnectionString = @"Server=(local); Initial Catalog = MontadoraDB; Integrated Security = true";
            services.AddDbContext<MontadoraContexto>(options => options.UseSqlServer(ConnectionString));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<CidadeRepository, CidadeRepository>();
            services.AddTransient<CidadeServices, CidadeServices>();

            services.AddTransient<ClienteRepository, ClienteRepository>();
            services.AddTransient<ClienteServices, ClienteServices>();

            services.AddTransient<FornecedorRepository, FornecedorRepository>();
            services.AddTransient<FonecedorServices, FonecedorServices>();

            services.AddTransient<MontadorRepository, MontadorRepository>();
            services.AddTransient<MontadorServices, MontadorServices>();

            services.AddTransient<PecaDoVeiculoRepository, PecaDoVeiculoRepository>();
            services.AddTransient<PecaDoVeiculoServices, PecaDoVeiculoServices>();

            services.AddTransient<PecaRepository, PecaRepository>();
            services.AddTransient<PecaServices, PecaServices>();

            services.AddTransient<UsuarioRepository, UsuarioRepository>();
            services.AddTransient<UsuarioServices, UsuarioServices>();

            services.AddTransient<VeiculoRepository, VeiculoRepository>();
            services.AddTransient<VeiculoServices, VeiculoServices>();
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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
