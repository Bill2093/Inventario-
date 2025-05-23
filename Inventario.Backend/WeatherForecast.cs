namespace Inventario.Backend
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public DayOfWeek Day => Date.DayOfWeek; // ← se agrega propiuedad 

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

}
