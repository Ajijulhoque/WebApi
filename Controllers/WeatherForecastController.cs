using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApi.Model;

namespace WebApi.Controllers
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
        private readonly IOptions<ProductInfoOptions> _productInfo;
        private readonly IOptions<BlobCacheSettingsOptions> _blobCacheSettingsOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<ProductInfoOptions> productInfo, IOptions<BlobCacheSettingsOptions> blobCacheSettingsOptions)
        {
            _logger = logger;
            _productInfo = productInfo;
            _blobCacheSettingsOptions = blobCacheSettingsOptions;
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }

        // [HttpGet("productinfo")]
        // public ProductInfoOptions Get()
        // {
        //     return _productInfo.Value;
        // }

        [HttpGet("blobcachesettings")]
        public BlobCacheSettingsOptions Get()
        {
            return _blobCacheSettingsOptions.Value;
        }
    }
}
