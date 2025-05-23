using HouseRentingSystem.Contacts.Agent;
using HouseRentingSystem.Contacts.House;
using HouseRentingSystem.Contacts.Statistic;
using HouseRentingSystem.Data;
using HouseRentingSystem.Data.Models;
using HouseRentingSystem.Services.Agent;
using HouseRentingSystem.Services.House;
using HouseRentingSystem.Services.Statistic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                   

            builder.Services.AddApplicationDbContext(builder.Configuration);
            builder.Services.AddApplicationIdentity(builder.Configuration);

            builder.Services.AddControllersWithViews(options=>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            builder.Services.AddApplicationServices();

            builder.Services.AddTransient<IHouseService, HouseService>();
            builder.Services.AddTransient<IAgentService, AgentService>();
            builder.Services.AddTransient<IStatisticsService, StatisticService>();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/500");
                app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRequestLocalization();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "House Details",
                    pattern: "/House/Details/{id}/{information}",
                    defaults: new { Controller = "House", Action = "Details" });

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            app.Run();
        }
    }
}