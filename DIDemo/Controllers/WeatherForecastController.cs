using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


        private IServiceProvider _ServiceProvider;
        private IExample _example;
        public WeatherForecastController(IExample Example)
        {
//           _ServiceProvider = ServiceProvider;
            _example = Example;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast>? Get()
        {
            Console.WriteLine(".............Request start................\n");

            //_Scoped.Process();
            _example.Implement();
            //var scoped1 = _ServiceProvider.GetService(typeof(Scoped));
            //var scoped2 = _ServiceProvider.GetService(typeof(Scoped));

            //var singleton1 = _ServiceProvider.GetService(typeof(Singleton));
            //var singleton2 = _ServiceProvider.GetService(typeof(Singleton));

            //var transient1 =_ServiceProvider.GetService(typeof(Transient));
            //var transient2 = _ServiceProvider.GetService(typeof(Transient));
            //var transient3 = _ServiceProvider.GetService(typeof(Transient));

            Console.WriteLine("\n...............Request End..................\n");
            return null;
        }
    }
}