using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace DIExample.Controllers
{
  public class HomeController : Controller
  {
    private readonly ICitiesService _citiesService1;
    private readonly ICitiesService _citiesService2;
    private readonly ICitiesService _citiesService3;

    //constructor
    public HomeController(ICitiesService citiesService1, ICitiesService citiesService2, ICitiesService citiesService3)
    {
            //create object of CitiesService class
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _citiesService3 = citiesService3;
            //new CitiesService();
    }

    [Route("/")]
    public IActionResult Index()
    {
      List<string> cities = _citiesService1.GetCities();

            ViewBag.GUIDInstanceID1 = _citiesService1.ServiceInstanceID;
            ViewBag.GUIDInstanceID2 = _citiesService2.ServiceInstanceID;
            ViewBag.GUIDInstanceID3 = _citiesService3.ServiceInstanceID;
      return View(cities);
    }
  }
}
