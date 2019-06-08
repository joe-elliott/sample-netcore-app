using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_netcore_app.Providers;

namespace sample_netcore_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FailController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            Environment.FailFast("Failing");

            return Ok();
        }
    }
}
