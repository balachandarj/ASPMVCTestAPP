using ASPMVCTestAPP.Models;
using ASPMVCTestAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCTestAPP.Controllers
{
    public class BikeController : Controller
    {
        BikeService bikeService;

        public BikeController()
        {
            bikeService = new BikeService();
        }
        public IActionResult Index()
        {

            List<Bike> bikes = bikeService.GetBikes();
            return View(bikes);
        }

        public IActionResult AddBike(Bike bike)
        {

            bikeService.AddBike(bike);
            return View();
        }

    }
}
