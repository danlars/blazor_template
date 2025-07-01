namespace weather.Models;
using System.Text.Json.Serialization;

public class WeatherForecast
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("hourly_units")]
    public HourlyUnits? HourlyUnits { get; set; }

    [JsonPropertyName("hourly")]
    public HourlyData? Hourly { get; set; }
}

// Ny klasse til at holde enhederne for målingerne
public class HourlyUnits
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public string? Temperature2m { get; set; }

    [JsonPropertyName("rain")]
    public string? Rain { get; set; }

    [JsonPropertyName("cloud_cover")]
    public string? CloudCover { get; set; }

    [JsonPropertyName("showers")]
    public string? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public string? Snowfall { get; set; }

    [JsonPropertyName("snow_depth")]
    public string? SnowDepth { get; set; }
}

// Ny klasse til at holde listerne med time-data
public class HourlyData
{
    [JsonPropertyName("time")]
    public List<string>? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public List<double>? Temperature2m { get; set; }

    [JsonPropertyName("rain")]
    public List<double>? Rain { get; set; }
        
    [JsonPropertyName("cloud_cover")]
    public List<int>? CloudCover { get; set; }

    [JsonPropertyName("showers")]
    public List<double>? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public List<double>? Snowfall { get; set; }

    [JsonPropertyName("snow_depth")]
    public List<double>? SnowDepth { get; set; }
}
