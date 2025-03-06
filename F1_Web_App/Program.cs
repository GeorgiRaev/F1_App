using F1_Web_App.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();

            // Registration MediatR
            builder.Services.AddMediatR(typeof(Program).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error/500");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseHsts();
            }

            // Seed roles and assign them to users
            using (var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                await SeedRolesAndAssignToUsersAsync(roleManager, userManager);
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                if (response.StatusCode == 404)
                {
                    response.Redirect("/Error/404");
                }
                else if (response.StatusCode == 500)
                {
                    response.Redirect("/Error/500");
                }
            });

            app.Run();
        }

        private static async Task SeedRolesAndAssignToUsersAsync(
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            var roles = new[] { "Administrator", "Moderator", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var users = new[]
            {
                new { UserId = "0804f098-3e4a-47a9-b6ea-8e5d7370ba92", Role = "Administrator" },
                new { UserId = "770ef33f-78ce-43aa-9dbb-7b454c754452", Role = "Moderator" }
            };

            foreach (var userRole in users)
            {
                var user = await userManager.FindByIdAsync(userRole.UserId);
                if (user != null && !await userManager.IsInRoleAsync(user, userRole.Role))
                {
                    await userManager.AddToRoleAsync(user, userRole.Role);
                }
            }
        }
    }
}
