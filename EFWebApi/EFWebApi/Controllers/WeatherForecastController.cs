using EFWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFWebApi.Controllers
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

        private readonly EFWebApiContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, EFWebApiContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public ActionResult<WeatherForecast> PostWeatherForecast(WeatherForecast wf)
        {
            if (wf == null)
                return BadRequest();

            _context.Add(wf);
            _context.SaveChanges();

            return CreatedAtAction(nameof(PostWeatherForecast), new WeatherForecast { Id = wf.Id }, wf);
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<IEnumerable<WeatherForecast>> Get() =>
            _context.WeatherForecasts.ToArray();

        [HttpGet("{id}")]
        public ActionResult<WeatherForecast> GetWeatherForecast(int id)
        {
            var wr = _context.WeatherForecasts.Find(id);

            if (wr == null)
            {
                return NotFound();
            }

            return Ok(wr);
        }

        [HttpPut("{id}")]
        public ActionResult<WeatherForecast> PutWeatherForecast(int id, WeatherForecast wf)
        {
            if (id != wf.Id)
                return BadRequest();

            _context.Entry(wf).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<WeatherForecast> DeleteWeatherForecast(int id)
        {
            var wr = _context.WeatherForecasts.Find(id);

            if(wr is null)
            {
                return NotFound();
            }

            _context.WeatherForecasts.Remove(wr);
            _context.SaveChanges();

            return wr;

        }
    }
}