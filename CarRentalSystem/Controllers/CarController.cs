using CarRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class CarController : Controller
    {
        static private List<Car> availableCars= new List<Car>{   
            new Car { Id = 1, Name = "Alto", PricePerDay = 3000 },
            new Car { Id = 2, Name = "Corolla", PricePerDay = 6000 },
            new Car { Id = 3, Name = "Civic", PricePerDay = 8000 }
        }; 
        static private List<Car> bookedCars = new List<Car>();
        [HttpGet]
        public IActionResult Index()
        {
            return View(availableCars);
        }
        [HttpPost]
        public IActionResult Book(int id)
        {
            var car = availableCars.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return RedirectToAction(nameof(Index));
            }
            availableCars.Remove(car);
            bookedCars.Add(car);
            return RedirectToAction(nameof(Booked));

        }
        [HttpGet]
        public IActionResult Booked(int id)
        {
            return View(bookedCars);

        }

    }
}
