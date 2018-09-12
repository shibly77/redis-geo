using Microsoft.AspNetCore.Mvc;


namespace RedisGeo.Controllers
{
    [Route("[controller]")]
    public class App : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return   @"< Our awesome app is running ! />" ;
        }

       
    }
}

