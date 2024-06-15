namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;
using lib_schoolmanagement;

public class ListBase : ComponentBase {
    protected WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync() {
        await Task.Delay(500);

        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast {
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }

    protected class WeatherForecast {
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    
}
