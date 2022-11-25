using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeaController : ControllerBase
    {
        private static readonly string[] TeaType = new[]
       {
            "Kara Çay", "Ihlamur"
        };

        [HttpGet]
        public ActionResult Get()
        {
            Request.Headers.ToList().ForEach(x =>
                Console.WriteLine(x.Key + " " + x.Value));

            Console.WriteLine("Host: " + Request.Host);

            Console.WriteLine("Path: " + Request.Path);
            

            Console.WriteLine("Çalıştı");

            return Ok(TeaType[Random.Shared.Next(TeaType.Length)]);
        }
    }
}
