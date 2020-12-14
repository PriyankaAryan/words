using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freez", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Ban", "Hot", "Swing", "Sandwitch"
        //};

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
          
            string[] Summaries = new string[] { 
                "Freez", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Ban", "Hot", "Swing", 
                "Sandwitch" ,"Table","Tab","East","Able","Last","Stable","Value","List","Handle"};
      

            return Summaries;
        }
    }
}
