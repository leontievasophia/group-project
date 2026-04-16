using Microsoft.AspNetCore.Mvc;
using group_project.Models;

namespace group_project.Controllers
{
    public class HomeController : Controller
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
}