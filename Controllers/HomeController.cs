using group_project.Services;
using Microsoft.AspNetCore.Mvc;
using group_project.Models;

namespace group_project.Controllers
{
    public class HomeController : Controller
    private readonly HoroscopeService _horoscopeService;
    public HomeController(HoroscopeService horoscopeService)
{
    _horoscopeService = horoscopeService;
}
    {
        public IActionResult Index()
        {
            var predictionService = new Prediction();
            string prediction = predictionService.GetRandomPrediction();

            ViewBag.PredictionText = prediction;

            return View();
        }

        public IActionResult Horoscope()
        {
            return View();
        }
    }
    public IActionResult HoroscopeDetails(string sign)
{
    var horoscope = _horoscopeService.GetHoroscope(sign);

    if (horoscope == null)
    {
        return RedirectToAction("Horoscope");
    }

    return View(horoscope);
}
}