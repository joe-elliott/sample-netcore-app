using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_netcore_app.Providers;

namespace sample_netcore_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        private IEchoProvider _provider;

        public EchoController(IEchoProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        public ActionResult<string> Get([FromQuery(Name="echo")]string echo)
        {
            return _provider.calculateEchoValue(echo);
        }
    }
}
