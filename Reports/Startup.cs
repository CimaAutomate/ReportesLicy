using System;
using System.IO;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.Security.Resources;
using Microsoft.EntityFrameworkCore;
using Reports.Services;
using Reports.Data;
using System.Reflection;
using DataSource.Common.Attributes;
using DataSource.Datasources.Impresiones;

namespace Reports {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
            RegisterAllSafeReportDataSources();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDevExpressControls();
            services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
            services
                .AddMvc()
                .AddNewtonsoftJson();
            services.ConfigureReportingServices(configurator => {
                configurator.ConfigureReportDesigner(designerConfigurator => {
                    designerConfigurator.RegisterObjectDataSourceWizardTypeProvider<ObjectDataSourceWizardCustomTypeProvider>();
                });
                configurator.ConfigureWebDocumentViewer(viewerConfigurator => {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                    viewerConfigurator.RegisterConnectionProviderFactory<CustomSqlDataConnectionProviderFactory>();
                });
                configurator.UseAsyncEngine();
            });
            services.AddSpaStaticFiles(configuration => {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddDbContext<ReportDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("ReportsDataConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, ReportDbContext db) {
            db.InitializeDatabase();
            var contentDirectoryAllowRule = DirectoryAccessRule.Allow(new DirectoryInfo(Path.Combine(env.ContentRootPath, "..", "Content")).FullName);
            AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow());
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment()) {
                app.UseSpaStaticFiles();
            }
            
            app.UseRouting();
            
            app.UseDevExpressControls();
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
            
            app.UseSpa(spa => {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment()) {
                    spa.UseAngularCliServer(npmScript: "start");
                    spa.Options.StartupTimeout = TimeSpan.FromSeconds(240);
                }
            });
        }

        public static void RegisterAllSafeReportDataSources()
        {
            // Obtener todos los ensamblados cargados (puedes ajustar esto para escanear solo los ensamblados que necesites)
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                // Obtener todas las clases en el ensamblado
                Type[] types;
                try
                {
                    types = assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException e)
                {
                    types = e.Types;
                }

                // Buscar clases con el atributo SafeReportDataSource
                foreach (var type in types)
                {
                    if (type == null) continue;

                    var attributes = type.GetCustomAttributes(typeof(ReportDataSource), false);

                    // Si la clase tiene el atributo SafeReportDataSource, registrala como confiable
                    if (attributes != null && attributes.Length > 0)
                    {
                        DevExpress.Utils.DeserializationSettings.RegisterTrustedClass(typeof(ImpresionesPorMunicipioDataSource));
                    }
                }
            }

        }

    }
}