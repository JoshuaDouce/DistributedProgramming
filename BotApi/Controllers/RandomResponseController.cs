using System;
using Microsoft.AspNetCore.Mvc;

namespace BotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomResponseController : ControllerBase
    {
        // GET: api/RandomResponse
        [HttpGet]
        public string Get()
        {
            var random = new Random();

            var x = random.Next(0, 5);

            switch (x)
            {
                case 0:
                    return "Ranom message 1";
                case 1:
                    return "Ranom message 2";
                case 2:
                    return "Ranom message 3";
                case 3:
                    return "Ranom message 4";
                case 4:
                    return "Ranom message 5";
                default:
                    return "Ranom message 6";
            }
        }
    }
}
