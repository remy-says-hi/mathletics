using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mathletics.Context;

namespace mathletics.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {

        [HttpGet("[action]")]
        public List<Question> GetAll(int startDateIndex)
        {   
            System.Console.WriteLine(Request.HttpContext.Connection.RemoteIpAddress);            
            List<Question> quiz = MathleticsData.GetQuiz();
            foreach(Question question in quiz)
            {
                question.CorrectAnswer = 0;
            }
            return quiz;
        }

    }
}
