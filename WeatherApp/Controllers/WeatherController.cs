using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Text.Json;
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

		[HttpGet]
		public async Task<IActionResult> Index()
        {
			Weather weather = await _weatherService.GetWeather("aalborg");
			return View(weather);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

		[HttpGet]
		public async Task<IActionResult> MyJson(string city)
		{
			var json = await _weatherService.GetWeatherJson(city);
			// Optional validation to fail fast if upstream returned garbage
			using var _ = JsonDocument.Parse(json);
			return Content(json, "application/json"); // jQuery dataType:"json" will parse it
		}
	}
}
