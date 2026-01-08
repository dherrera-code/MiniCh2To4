using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using miniChTwoToFour.Services;

namespace miniChTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThanOrLessController : ControllerBase
    {
        private readonly GreaterOrLessService _greaterOrLessThan;

        public GreaterThanOrLessController(GreaterOrLessService greaterOrLessThan)
        {
            _greaterOrLessThan = greaterOrLessThan;
        }

        [HttpPost("/{num1}/{num2}")]
        public string GreaterOrLess(int num1, int num2)
        {
            return _greaterOrLessThan.GreaterOrLessThan(num1,num2);
        }
    }
}