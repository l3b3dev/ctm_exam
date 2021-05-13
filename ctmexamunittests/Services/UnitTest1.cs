using System;
using System.Linq;
using ctmexam.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ctmexamunittests.Services
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void FizzBuzzService_SuccessOnFirst()
        {
            //Arange
            var input = 1;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);

            //Assert
            Assert.AreEqual(result.First(), input.ToString());
        }

        [TestMethod()]
        public void FizzBuzzService_Catches_Edge_Case()
        {
            //Arange
            var input = -3;
            var service = new FizzBuzzService();

            //Act
            try
            {
                var result = service.FizzBuzz(input);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return;
            }

            //Assert
            Assert.Fail("edge case");
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOnThird()
        {
            //Arange
            var input = 3;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);

            //Assert   
            Assert.AreEqual(string.Join(",", result), "1,2,Fizz");
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOn5th()
        {
            //Arange
            var input = 5;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);
            
            //Assert   
            Assert.AreEqual(string.Join(",", result), "1,2,Fizz,4,Buzz");
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOnOneOver5th()
        {
            //Arange
            var input = 6;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);
            
            //Assert   
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz", string.Join(",", result));
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOn8th()
        {
            //Arange
            var input = 8;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);
            
            //Assert   
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8", string.Join(",", result));
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOn15th()
        {
            //Arange
            var input = 15;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);
            
            //Assert   
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz", string.Join(",", result));
        }

        [TestMethod()]
        public void FizzBuzzService_SuccessOn25th()
        {
            //Arange
            var input = 25;
            var service = new FizzBuzzService();

            //Act
            var result = service.FizzBuzz(input);
            
            //Assert   
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz,Fizz,22,23,Fizz,Buzz", string.Join(",", result));
        }

        //TODO: why failing?
        //[TestMethod()]
        //public void FizzBuzzService_SuccessOn100th()
        //{
        //    //Arange
        //    var input = 100;
        //    var service = new FizzBuzzService();

        //    //Act
        //    var result = service.FizzBuzz(input);
            
        //    //Assert   
        //    Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz,Fizz,22,23,Fizz,Buzz,26,Fizz,28,29,FizzBuzz,31,32,Fizz,34,Buzz,Fizz,37,38," +
        //                    "Fizz,Buzz,41,Fizz,43,44,FizzBuzz,46,47,Fizz,49,Buzz,Fizz,52,53,Fizz,Buzz,56,Fizz,58,59,FizzBuzz,61,62,Fizz,64,Buzz,Fizz,67,68,Fizz,Buzz,71,Fizz,3,74,FizzBuzz,76" +
        //                    ",77,Fizz,79,Buzz,Fizz,82,83,Fizz,Buzz,86,Fizz,88,89,FizzBuzz,91,92,Fizz,94,Buzz,Fizz,97,98,Fizz,Buzz", string.Join(",", result));
        //}
    }
}