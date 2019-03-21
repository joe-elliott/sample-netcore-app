using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_netcore_app.Providers;

namespace sample_netcore_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private IFibonacciProvider _provider;

        public FibonacciController(IFibonacciProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        public ActionResult<int> Get()
        {
            return _provider.calculateFibonacciValue(1);
        }

        [HttpGet("{position}")]
        public ActionResult<int> Get(int position)
        {
            return _provider.calculateFibonacciValue(position);
        }
    }
}
