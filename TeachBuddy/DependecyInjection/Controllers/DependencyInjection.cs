using DependecyInjection.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjection.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DependencyInjection : ControllerBase
    {
        private INumGenerator _numGenerator;

        public DependencyInjection(INumGenerator numGenerator)
        {
            _numGenerator = numGenerator;
        }

        [HttpGet]
        public int Get()
        {
            var num = _numGenerator.RandomValue;
            return num;
        }
    }
}
