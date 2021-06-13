using Microsoft.AspNetCore.Mvc;

namespace PitchFromFridge.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("api/test")]
        public string GetTest()
        {
            return "Success";
        }

        [HttpGet]
        [Route("api/test2")]
        public string GetTest2()
        {
            return "Success55";
        }
    }
}