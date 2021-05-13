using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctmexam.Services;
using ctmexam.Services.Interfaces;

namespace ctmexam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        //TODO: inject this later
        private readonly IFizzBuzzService _service = new FizzBuzzService();

        public IEnumerable<string> Get(int n)
        {
            return _service.FizzBuzz(n);
        }
    }
}
