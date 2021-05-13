using System;
using System.Collections.Generic;
using System.Linq;
using ctmexam.Services.Interfaces;

namespace ctmexam.Services
{
    /// <summary>
    /// Implementation of buz. logic per: Travel CTM Back-EndEngineer Interview Problem
    /// </summary>
    /// <seealso cref="ctmexam.Services.Interfaces.IFizzBuzzService" />
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// •For each multiple of 3, print "Fizz" instead of the number.
        /// •For each multiple of 5, print "Buzz" instead of the number.
        /// •For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<string> FizzBuzz(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException("n must be greater then 0");

            if( n > 100)
                throw new ArgumentOutOfRangeException("n must be less then 101");

            var result = new List<string>();

            //ugly hack for now
            foreach (var i in Enumerable.Range(1,n))
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    continue;
                }
                
                //print the number
                result.Add(i.ToString());
            }

            return result;
        }
    }
}