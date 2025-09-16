using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using WeatherApp.Models;
using WeatherApp.Service;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly WeatherService _weatherService;

		public WeatherController(ILogger<WeatherController> logger, WeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
		}

		[HttpGet("{city}")]
		public async Task<ActionResult> Index(string city)
        {
			if (string.IsNullOrEmpty(city))
				city = "Aalborg";

			Weather Weather = await _weatherService.GetWeather(city);
			return View(Weather);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
