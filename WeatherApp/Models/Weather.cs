namespace WeatherApp.Models
{
	public class Weather
	{
		public Timelines? timelines { get; set; }
		public Location? location { get; set; }
	}

	public class Timelines
	{
		public Minutely[]? minutely { get; set; }
		public Hourly[]? hourly { get; set; }
		public Daily[]? daily { get; set; }
	}

	public class Minutely
	{
		public DateTime? time { get; set; }
		public WeatherValueMinutely? values { get; set; }
	}

	public class WeatherValueMinutely
	{
		public double? altimeterSetting { get; set; }
		public double? cloudBase { get; set; }
		public double? cloudCeiling { get; set; }
		public double? cloudCover { get; set; }
		public double? dewPoint { get; set; }
		public double? evapotranspiration { get; set; }
		public double? freezingRainIntensity { get; set; }
		public double? humidity { get; set; }
		public double? iceAccumulation { get; set; }
		public double? iceAccumulationLwe { get; set; }
		public double? precipitationProbability { get; set; }
		public double? pressureSeaLevel { get; set; }
		public double? pressureSurfaceLevel { get; set; }
		public double? rainAccumulation { get; set; }
		public double? rainIntensity { get; set; }
		public double? sleetAccumulation { get; set; }
		public double? sleetAccumulationLwe { get; set; }
		public double? sleetIntensity { get; set; }
		public double? snowAccumulation { get; set; }
		public double? snowAccumulationLwe { get; set; }
		public double? snowDepth { get; set; }
		public double? snowIntensity { get; set; }
		public double? temperature { get; set; }
		public double? temperatureApparent { get; set; }
		public double? uvHealthConcern { get; set; }
		public double? uvIndex { get; set; }
		public double? visibility { get; set; }
		public double? weatherCode { get; set; }
		public double? windDirection { get; set; }
		public double? windGust { get; set; }
		public double? windSpeed { get; set; }
	}

	public class Hourly
	{
		public DateTime? time { get; set; }
		public WeatherValueHourly? values { get; set; }
	}

	public class WeatherValueHourly
	{
		public double? altimeterSetting { get; set; }
		public double? cloudBase { get; set; }
		public double? cloudCeiling { get; set; }
		public double? cloudCover { get; set; }
		public double? dewPoint { get; set; }
		public double? evapotranspiration { get; set; }
		public double? freezingRainIntensity { get; set; }
		public double? humidity { get; set; }
		public double? iceAccumulation { get; set; }
		public double? iceAccumulationLwe { get; set; }
		public double? precipitationProbability { get; set; }
		public double? pressureSeaLevel { get; set; }
		public double? pressureSurfaceLevel { get; set; }
		public double? rainAccumulation { get; set; }
		public double? rainIntensity { get; set; }
		public double? sleetAccumulation { get; set; }
		public double? sleetAccumulationLwe { get; set; }
		public double? sleetIntensity { get; set; }
		public double? snowAccumulation { get; set; }
		public double? snowAccumulationLwe { get; set; }
		public double? snowDepth { get; set; }
		public double? snowIntensity { get; set; }
		public double? temperature { get; set; }
		public double? temperatureApparent { get; set; }
		public double? uvHealthConcern { get; set; }
		public double? uvIndex { get; set; }
		public double? visibility { get; set; }
		public double? weatherCode { get; set; }
		public double? windDirection { get; set; }
		public double? windGust { get; set; }
		public double? windSpeed { get; set; }
	}

	public class Daily
	{
		public DateTime? time { get; set; }
		public WeatherValueDaily? values { get; set; }
	}

	public class WeatherValueDaily
	{
		public double? altimeterSettingAvg { get; set; }
		public double? altimeterSettingMax { get; set; }
		public double? altimeterSettingMin { get; set; }
		public double? cloudBaseAvg { get; set; }
		public double? cloudBaseMax { get; set; }
		public double? cloudBaseMin { get; set; }
		public double? cloudCeilingAvg { get; set; }
		public double? cloudCeilingMax { get; set; }
		public double? cloudCeilingMin { get; set; }
		public double? cloudCoverAvg { get; set; }
		public double? cloudCoverMax { get; set; }
		public double? cloudCoverMin { get; set; }
		public double? dewPointAvg { get; set; }
		public double? dewPointMax { get; set; }
		public double? dewPointMin { get; set; }
		public double? evapotranspirationAvg { get; set; }
		public double? evapotranspirationMax { get; set; }
		public double? evapotranspirationMin { get; set; }
		public double? evapotranspirationSum { get; set; }
		public double? freezingRainIntensityAvg { get; set; }
		public double? freezingRainIntensityMax { get; set; }
		public double? freezingRainIntensityMin { get; set; }
		public double? humidityAvg { get; set; }
		public double? humidityMax { get; set; }
		public double? humidityMin { get; set; }
		public double? iceAccumulationAvg { get; set; }
		public double? iceAccumulationLweAvg { get; set; }
		public double? iceAccumulationLweMax { get; set; }
		public double? iceAccumulationLweMin { get; set; }
		public double? iceAccumulationLweSum { get; set; }
		public double? iceAccumulationMax { get; set; }
		public double? iceAccumulationMin { get; set; }
		public double? iceAccumulationSum { get; set; }
		public DateTime? moonriseTime { get; set; }
		public DateTime? moonsetTime { get; set; }
		public double? precipitationProbabilityAvg { get; set; }
		public double? precipitationProbabilityMax { get; set; }
		public double? precipitationProbabilityMin { get; set; }
		public double? pressureSeaLevelAvg { get; set; }
		public double? pressureSeaLevelMax { get; set; }
		public double? pressureSeaLevelMin { get; set; }
		public double? pressureSurfaceLevelAvg { get; set; }
		public double? pressureSurfaceLevelMax { get; set; }
		public double? pressureSurfaceLevelMin { get; set; }
		public double? rainAccumulationAvg { get; set; }
		public double? rainAccumulationMax { get; set; }
		public double? rainAccumulationMin { get; set; }
		public double? rainAccumulationSum { get; set; }
		public double? rainIntensityAvg { get; set; }
		public double? rainIntensityMax { get; set; }
		public double? rainIntensityMin { get; set; }
		public double? sleetAccumulationAvg { get; set; }
		public double? sleetAccumulationLweAvg { get; set; }
		public double? sleetAccumulationLweMax { get; set; }
		public double? sleetAccumulationLweMin { get; set; }
		public double? sleetAccumulationLweSum { get; set; }
		public double? sleetAccumulationMax { get; set; }
		public double? sleetAccumulationMin { get; set; }
		public double? sleetIntensityAvg { get; set; }
		public double? sleetIntensityMax { get; set; }
		public double? sleetIntensityMin { get; set; }
		public double? snowAccumulationAvg { get; set; }
		public double? snowAccumulationLweAvg { get; set; }
		public double? snowAccumulationLweMax { get; set; }
		public double? snowAccumulationLweMin { get; set; }
		public double? snowAccumulationLweSum { get; set; }
		public double? snowAccumulationMax { get; set; }
		public double? snowAccumulationMin { get; set; }
		public double? snowAccumulationSum { get; set; }
		public double? snowDepthAvg { get; set; }
		public double? snowDepthMax { get; set; }
		public double? snowDepthMin { get; set; }
		public double? snowDepthSum { get; set; }
		public double? snowIntensityAvg { get; set; }
		public double? snowIntensityMax { get; set; }
		public double? snowIntensityMin { get; set; }
		public DateTime? sunriseTime { get; set; }
		public DateTime? sunsetTime { get; set; }
		public double? temperatureApparentAvg { get; set; }
		public double? temperatureApparentMax { get; set; }
		public double? temperatureApparentMin { get; set; }
		public double? temperatureAvg { get; set; }
		public double? temperatureMax { get; set; }
		public double? temperatureMin { get; set; }
		public double? uvHealthConcernAvg { get; set; }
		public double? uvHealthConcernMax { get; set; }
		public double? uvHealthConcernMin { get; set; }
		public double? uvIndexAvg { get; set; }
		public double? uvIndexMax { get; set; }
		public double? uvIndexMin { get; set; }
		public double? visibilityAvg { get; set; }
		public double? visibilityMax { get; set; }
		public double? visibilityMin { get; set; }
		public double? weatherCodeMax { get; set; }
		public double? weatherCodeMin { get; set; }
		public double? windDirectionAvg { get; set; }
		public double? windGustAvg { get; set; }
		public double? windGustMax { get; set; }
		public double? windGustMin { get; set; }
		public double? windSpeedAvg { get; set; }
		public double? windSpeedMax { get; set; }
		public double? windSpeedMin { get; set; }
	}

	public class Location
	{
		public double? lat { get; set; }
		public double? lon { get; set; }
		public string? name { get; set; }
		public string? type { get; set; }
	}
}
