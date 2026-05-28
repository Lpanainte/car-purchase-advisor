using CarPurchaseAdvisor.Data;
using CarPurchaseAdvisor.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")));

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    db.Database.EnsureCreated();

    if (!db.Cars.Any())
    {
        db.Cars.AddRange(

            new Car
            {
                Brand = "Bugatti",
                Model = "Chiron",
                Year = 2026,
                Price = 5200000,
                FuelType = "Petrol",
                Horsepower = 1500,
                ImageUrl = "https://cdn.pixabay.com/photo/2020/01/19/17/26/bugatti-4776752_1280.jpg"
            },

            new Car
            {
                Brand = "Tesla",
                Model = "S Plaid",
                Year = 2026,
                Price = 120000,
                FuelType = "Electric",
                Horsepower = 1020,
                ImageUrl = "https://cdn.pixabay.com/photo/2021/09/29/09/04/tesla-6660316_1280.jpg"
            },

            new Car
            {
                Brand = "Ferrari",
                Model = "SF90 Stradale",
                Year = 2026,
                Price = 650000,
                FuelType = "Hybrid",
                Horsepower = 1000,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Ferrari_SF90_Stradale_Genf_2019_1Y7A5661.jpg"
            },

            new Car
            {
                Brand = "Lamborghini",
                Model = "Revuelto",
                Year = 2026,
                Price = 700000,
                FuelType = "Hybrid",
                Horsepower = 1001,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Lamborghini_Revuelto.jpg"
            },

            new Car
            {
                Brand = "Porsche",
                Model = "911 Turbo S",
                Year = 2026,
                Price = 280000,
                FuelType = "Petrol",
                Horsepower = 650,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/04/01/12/11/porsche-1300233_1280.png"
            }

        );

        db.SaveChanges();
    }
}

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();