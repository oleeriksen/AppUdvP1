namespace Modul7;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello modul 7");
        var service = new SunApiService();
        double lat = 56.1567, lng = 10.2108;
        var times = await service.GetSunriseSunsetAsync(lat, lng, DateTime.Now);
        
        Console.WriteLine($" Solopgang: {times.sunrise.ToShortTimeString()}");
        Console.WriteLine($"Solnedgang: {times.sunset.ToShortTimeString()}");

    }
}