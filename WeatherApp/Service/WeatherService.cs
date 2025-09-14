using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Web;
using WeatherApp.Models;

namespace WeatherApp.Service
{
	public class WeatherService
	{
		private readonly string _apiKey;
		private ILogger<WeatherService> _logger;

		public WeatherService(ILogger<WeatherService> logger, IOptions<ApiSettings> apiOptions)
		{
			_logger = logger;
			_apiKey = apiOptions.Value.MyApiKey.Trim();
			_logger.LogInformation("Apikey length: " + _apiKey.Length);
		}
		
		public async Task<Weather> GetWeather(string location)
		{
			string body;

			var clientHandler = new HttpClientHandler
			{
				AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
			};
			var client = new HttpClient(clientHandler);
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://api.tomorrow.io/v4/weather/forecast?location={HttpUtility.UrlEncode(location)}&apikey={_apiKey}"),
				Headers =
				{
					{ "accept", "application/json" },
				},
			};
			using var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			body = await response.Content.ReadAsStringAsync();
			Weather? weatherForecast = JsonSerializer.Deserialize<Weather>(body);

			return weatherForecast;
		}
	}
}