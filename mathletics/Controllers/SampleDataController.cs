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
            List<Question> questions = new List<Question>();
            questions.Add(Quizmaster.QuizAddition());
            questions.Add(Quizmaster.QuizAddition());
            questions.Add(Quizmaster.QuizAddition());

            foreach(Question question in questions)
            {
                question.CorrectAnswer = 0;
            }
            return questions;
        }

    }
}
