using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using AFM_Project.Models;
using System;
using Microsoft.IdentityModel.Tokens;

namespace AFM_Project
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
            // selon https://www.codemag.com/Article/1809031/Security-in-Angular-Part-2
            // Get JWT Settings from JSON file
            JwtSettings settings;
            settings = GetJwtSettings();
            services.AddSingleton<JwtSettings>(settings);

            // Register Jwt as the Authentication service
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
            .AddJwtBearer("JwtBearer", jwtBearerOptions =>
            {
                jwtBearerOptions.TokenValidationParameters =
                  new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                        System.Text.Encoding.UTF8.GetBytes(settings.Key)),
                        ValidateIssuer = true,
                        ValidIssuer = settings.Issuer,

                        ValidateAudience = true,
                        ValidAudience = settings.Audience,

                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.FromMinutes(
                        settings.MinutesToExpiration)
                    };
            });


            services.AddDbContext<SeilernContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SeilernDB")));

            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            //ajout auth            
            app.UseAuthentication();
            app.UseAuthorization();          

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
           
            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });     
        }

        public JwtSettings GetJwtSettings()
        {
            JwtSettings settings = new JwtSettings();
            settings.Key =
              Configuration["JwtSettings:key"];
            settings.Audience =
              Configuration["JwtSettings:audience"];
            settings.Issuer =
              Configuration["JwtSettings:issuer"];
            settings.MinutesToExpiration =
              Convert.ToInt32(
                Configuration["JwtSettings: minutesToExpiration"]);
          return settings;
        }
    }
}
