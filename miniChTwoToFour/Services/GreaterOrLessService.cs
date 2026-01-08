using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniChTwoToFour.Services
{
    public class GreaterOrLessService
    {
        public string GreaterOrLessThan(int num1, int num2)
        {
            if(num1 > num2)
            return $"{num1} is greater than {num2}!";
            else if (num1 < num2)
            return $"{num1} is less than {num2}!";
            else
            return $"{num1} is equal to {num2}!";
        }
    }
}