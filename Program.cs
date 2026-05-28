using CarPurchaseAdvisor.Data;
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
                Year = 2026,if (!db.Cars.Any())
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
                },

                new Car
                {
                    Brand = "Audi",
                    Model = "RS7",
                    Year = 2026,
                    Price = 160000,
                    FuelType = "Petrol",
                    Horsepower = 630,
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/01/18/21/33/audi-3099880_1280.jpg"
                },

                new Car
                {
                    Brand = "McLaren",
                    Model = "765LT",
                    Year = 2026,
                    Price = 450000,
                    FuelType = "Petrol",
                    Horsepower = 755,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/27/14/56/auto-2179220_1280.jpg"
                },

                new Car
                {
                    Brand = "Rimac",
                    Model = "Nevera",
                    Year = 2026,
                    Price = 2400000,
                    FuelType = "Electric",
                    Horsepower = 1914,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Rimac_Nevera_IAA_2021_1X7A0205.jpg"
                },

                new Car
                {
                    Brand = "Rolls-Royce",
                    Model = "Spectre",
                    Year = 2026,
                    Price = 500000,
                    FuelType = "Electric",
                    Horsepower = 584,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Rolls-Royce_Spectre_1X7A5337.jpg"
                },

                new Car
                {
                    Brand = "BMW",
                    Model = "M4 Competition",
                    Year = 2026,
                    Price = 130000,
                    FuelType = "Petrol",
                    Horsepower = 530,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/11/29/03/53/auto-1868726_1280.jpg"
                }

            );

            db.SaveChanges();
        }
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
                },

                new Car
                {
                    Brand = "Audi",
                    Model = "RS7",
                    Year = 2026,
                    Price = 160000,
                    FuelType = "Petrol",
                    Horsepower = 630,
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/01/18/21/33/audi-3099880_1280.jpg"
                },

                new Car
                {
                    Brand = "McLaren",
                    Model = "765LT",
                    Year = 2026,
                    Price = 450000,
                    FuelType = "Petrol",
                    Horsepower = 755,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/27/14/56/auto-2179220_1280.jpg"
                },

                new Car
                {
                    Brand = "Rimac",
                    Model = "Nevera",
                    Year = 2026,
                    Price = 2400000,
                    FuelType = "Electric",
                    Horsepower = 1914,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Rimac_Nevera_IAA_2021_1X7A0205.jpg"
                },

                new Carif(!db.Cars.Any())
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
        },

        new Car
        {
            Brand = "Audi",
            Model = "RS7",
            Year = 2026,
            Price = 160000,
            FuelType = "Petrol",
            Horsepower = 630,
            ImageUrl = "https://cdn.pixabay.com/photo/2018/01/18/21/33/audi-3099880_1280.jpg"
        },

        new Car
        {
            Brand = "McLaren",
            Model = "765LT",
            Year = 2026,
            Price = 450000,
            FuelType = "Petrol",
            Horsepower = 755,
            ImageUrl = "https://cdn.pixabay.com/photo/2017/03/27/14/56/auto-2179220_1280.jpg"
        },

        new Car
        {
            Brand = "Rimac",
            Model = "Nevera",
            Year = 2026,
            Price = 2400000,
            FuelType = "Electric",
            Horsepower = 1914,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Rimac_Nevera_IAA_2021_1X7A0205.jpg"
        },

        new Car
        {
            Brand = "Rolls-Royce",
            Model = "Spectre",
            Year = 2026,
            Price = 500000,
            FuelType = "Electric",
            Horsepower = 584,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Rolls-Royce_Spectre_1X7A5337.jpg"
        },

        new Car
        {
            Brand = "BMW",
            Model = "M4 Competition",
            Year = 2026,
            Price = 130000,
            FuelType = "Petrol",
            Horsepower = 530,
            ImageUrl = "https://cdn.pixabay.com/photo/2016/11/29/03/53/auto-1868726_1280.jpg"
        }

    );

    db.SaveChanges();
}
                {
                    Brand = "Rolls-Royce",
                    Model = "Spectre",
                    Year = 2026,
                    Price = 500000,
                    FuelType = "Electric",
                    Horsepower = 584,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Rolls-Royce_Spectre_1X7A5337.jpg"
                },

                new Car
                {
                    Brand = "BMW",
                    Model = "M4 Competition",
                    Year = 2026,
                    Price = 130000,
                    FuelType = "Petrol",
                    Horsepower = 530,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/11/29/03/53/auto-1868726_1280.jpg"
                }

            );

            db.SaveChanges();
        }
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
            },

            new Car
            {
                Brand = "Audi",
                Model = "RS7",
                Year = 2026,
                Price = 160000,
                FuelType = "Petrol",
                Horsepower = 630,
                ImageUrl = "https://cdn.pixabay.com/photo/2018/01/18/21/33/audi-3099880_1280.jpg"
            },

            new Car
            {
                Brand = "McLaren",
                Model = "765LT",
                Year = 2026,
                Price = 450000,
                FuelType = "Petrol",
                Horsepower = 755,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/03/27/14/56/auto-2179220_1280.jpg"
            },

            new Car
            {
                Brand = "Rimac",
                Model = "Nevera",
                Year = 2026,
                Price = 2400000,
                FuelType = "Electric",
                Horsepower = 1914,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Rimac_Nevera_IAA_2021_1X7A0205.jpg"
            },

            new Car
            {
                Brand = "Rolls-Royce",
                Model = "Spectre",
                Year = 2026,
                Price = 500000,
                FuelType = "Electric",
                Horsepower = 584,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Rolls-Royce_Spectre_1X7A5337.jpg"
            },

            new Car
            {
                Brand = "BMW",
                Model = "M4 Competition",
                Year = 2026,
                Price = 130000,
                FuelType = "Petrol",
                Horsepower = 530,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/11/29/03/53/auto-1868726_1280.jpg"
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