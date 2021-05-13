using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctmexam.Services.Interfaces
{
    /// <summary>
    /// Wraps fizz buzz biz logic
    /// </summary>
    interface IFizzBuzzService
    {
        public List<string> FizzBuzz(int n);
    }
}
