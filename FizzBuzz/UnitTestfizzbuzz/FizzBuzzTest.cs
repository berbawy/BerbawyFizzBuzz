using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Controllers;

namespace UnitTestfizzbuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
       

      
        [TestMethod]
        
        public void IsFizzTest()
        {
            FizzbuzzController FBC = new FizzbuzzController();
            int Value = 3;
            bool IsFizz = FBC.IsFIZZ(Value);
            Assert.IsTrue(IsFizz);
        }

        [TestMethod]
        public void IsBuzzTest()
        {
            FizzbuzzController FBC = new FizzbuzzController();
            int Value = 5;
            bool IsBuzz= FBC.IsBUZZ(Value);
            Assert.IsTrue(IsBuzz);
        }
        [TestMethod]
        public void IsNumberTest()
        {
            FizzbuzzController FBC = new FizzbuzzController();
            string txt = "123";
            bool isNumeric = FBC.IsNumber(txt);
            Assert.IsTrue(isNumeric);

        }

        [TestMethod]
        public void TestValue5()
        {
            FizzbuzzController FBC = new FizzbuzzController();
            string txt = "5";
            string Result = FBC.GetFizzBuzzResult(txt);
            string ExpR = "1 2 Fizz 4 Buzz";
            Assert.AreEqual(ExpR, Result);

        }

    }
}

