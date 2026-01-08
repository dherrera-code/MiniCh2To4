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
    public class TwoQuestionsController(TwoQuestionsService questions) : ControllerBase
    {
        private readonly TwoQuestionsService _twoQuestions = questions;

        [HttpPost("WhatIsYourName/{name}/WhatTimeDidYouWakeUpToday/{time}")]
        public string TwoQuestions(string name, string time)
        {
            return _twoQuestions.TwoQuestions(name, time);
        }
    }
}