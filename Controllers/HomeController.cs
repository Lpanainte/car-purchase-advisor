using Microsoft.AspNetCore.Mvc;
using CarPurchaseAdvisor.Data;
using CarPurchaseAdvisor.Models;

namespace CarPurchaseAdvisor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cars = _context.Cars
                .OrderByDescending(x => x.Price)
                .ToList();

            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Add(car);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(car);
        }

        public IActionResult Delete(int id)
        {
            var car = _context.Cars.Find(id);

            if (car != null)
            {
                _context.Cars.Remove(car);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var car = _context.Cars.Find(id);

            return View(car);
        }

        public IActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(string budget,
                                  string fuel,
                                  string type)
        {
            var recommendedCar = _context.Cars.FirstOrDefault();

            if (fuel == "Electric")
            {
                recommendedCar =
                    _context.Cars
                    .FirstOrDefault(x => x.FuelType == "Electric");
            }

            else if (type == "Sport")
            {
                recommendedCar =
                    _context.Cars
                    .OrderByDescending(x => x.Horsepower)
                    .FirstOrDefault();
            }

            else if (budget == "Luxury")
            {
                recommendedCar =
                    _context.Cars
                    .OrderByDescending(x => x.Price)
                    .FirstOrDefault();
            }

            return View("QuizResult", recommendedCar);
        }

        public IActionResult Edit(int id)
        {
            var car = _context.Cars.Find(id);

            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Update(car);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(car);
        }

        public IActionResult Compare()
        {
            var cars = _context.Cars.ToList();

            return View(cars);
        }
        public IActionResult Favorites()
        {
            var cars = _context.Cars.ToList();

            return View(cars);
        }
    }
}