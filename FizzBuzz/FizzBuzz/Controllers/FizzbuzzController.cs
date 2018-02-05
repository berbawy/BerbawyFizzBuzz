using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    public class FizzbuzzController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetFizzBuzz(string txtValue)
        {
            
            try
            {
                string Result = GetFizzBuzzResult(txtValue);
                return Json(new { results = Result });
            }
            catch(Exception ex)
            {
                return Json(new { results = ex.Message });
            }
        }

       

        public string GetFizzBuzzResult(string val)
        {
            if (IsNumber(val))
            {
                int number = int.Parse(val);
                string Result = "";
                for (int i = 1; i <= number; i++)
                {
                    var printNumber = string.Empty;
                    if (IsFIZZ(i)) printNumber += "Fizz";
                    if (IsBUZZ(i)) printNumber += "Buzz";
                    if (IsprintNumber(printNumber))
                        printNumber = (i).ToString();
                    Result += " " + printNumber;
                }
                return Result.Trim();
            }
            else
                return "Please enter valid number";
        }
        public bool IsFIZZ(int v)
        {
            return v % 3 == 0;
        }
        public bool IsBUZZ(int v)
        {
            return v % 5 == 0;
        }

        public bool IsNumber(string value)
        {
            int n;
            return int.TryParse(value, out n);
        }
        public bool IsprintNumber(string printNumber)
        {
            return String.IsNullOrEmpty(printNumber);
        }
    }
}