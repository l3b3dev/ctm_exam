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
        private IFizzBuzzService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public FizzBuzzController(IFizzBuzzService service)
        {
            _service = service;
        }

        /// <summary>
        /// Expose FizzBuzz service to outside
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public IEnumerable<string> Get(int n)
        {
            //TODO: return 400 back to user
            if (n <= 0)
                return new List<string> {"n must be greater then 0"};

            return n > 100 ? new List<string> {"n must be less then 101"} : _service.FizzBuzz(n);
        }
    }
}
