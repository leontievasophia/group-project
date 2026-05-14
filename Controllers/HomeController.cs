using Microsoft.AspNetCore.Mvc;
using group_project.Models;

namespace group_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string prediction = Prediction.GetRandomPrediction();

            ViewBag.PredictionText = prediction;

            return View();
        }

        public IActionResult Horoscope()
        {
            return View();
        }
<<<<<<< Updated upstream
=======

        public IActionResult Compatibility()
        {
            return View();
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
>>>>>>> Stashed changes
    }
}