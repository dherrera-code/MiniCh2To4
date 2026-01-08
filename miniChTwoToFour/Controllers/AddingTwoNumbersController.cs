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
    public class AddingTwoNumbersController : ControllerBase
    {

        private readonly AddTwoNumbersService _addTwoNumbersService;

        public AddingTwoNumbersController(AddTwoNumbersService addTwoNumbersService)
        {
            _addTwoNumbersService = addTwoNumbersService;
        }

        [HttpPost("{num1}/{num2}")]
        
        public string AddingTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersService.AddTwoNums(num1,num2);
        }
    }
}