using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace pimentadotnetapirest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FernandoController : ControllerBase
    {
       
        [HttpGet]
        public List<WeatherForecast> ComLista()
        {
            List<WeatherForecast> list = new List<WeatherForecast>();
            WeatherForecast a = new WeatherForecast { Fernando = "fefe" };

            list.Add(a);

            return list;
        }


        [HttpPost]
        public List<WeatherForecast> Post(WeatherForecast b)
        {
            List<WeatherForecast> list = new List<WeatherForecast>();
            list.Add(b);
            return list;
        }

    }
}
