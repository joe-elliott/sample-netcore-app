using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_netcore_app.Providers;

namespace sample_netcore_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IFibonnaciProvider _provider;

        public ValuesController(IFibonnaciProvider provider)
        {
            _provider = provider;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<int> Get()
        {
            return _provider.calculateFibonnaciValue(1);
        }

        // GET api/values/5
        [HttpGet("{position}")]
        public ActionResult<int> Get(int position)
        {
            return _provider.calculateFibonnaciValue(position);
        }
    }
}
