using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Security.Cryptography;
using LoveMarriage.Data.Models;

namespace CoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //var loveMarriageDBContext = new LoveMarriageDBContext();
            //var users = loveMarriageDBContext.LoveMarriageUsers.ToList();
            //var sha1 = new SHA1CryptoServiceProvider();
            ////var hashPass = sha1.ComputeHash("sandippatel");
            //loveMarriageDBContext.LoveMarriageUsers.Add(new LoveMarriageUsers { UserName = "mansapatil007", UserEmailId = "sandippatel8990.sp@gmail.com", UserPassword = String.GetHashCode("sandippatel").ToString() });
            //loveMarriageDBContext.SaveChanges();

            var rng = new Random();
            
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
