using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniChTwoToFour.Services
{
    public class AddTwoNumbersService
    {
        // public AddTwoNumbersService()
        // {
            
        // }

        public string AddTwoNums(int num1, int num2)
        {
            return $"The Sum of {num1} and {num2} is {num1+num2}!";
        }
    }
}