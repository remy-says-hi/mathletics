using System.Collections.Generic;
using mathletics.Context;
using System.Collections;
using System;
using System.Linq;

namespace mathletics
{
    public static class Quizmaster
    {        
        public static List<Question> CreateQuiz()
        {
            List<Question> questions = new List<Question>();                        
            

            return questions;
        }

        public static Question QuizAddition()
        {
            Random random = new System.Random();
            Question question = new Question();
            int min = 1, max = 100;            
            int value1 = random.Next(min, max);
            int value2 = random.Next(min, max);
            
            question.Prompt = $"{value1} + {value2} =";
            int one, two, three;
            one = random.Next(min, max) + random.Next(min, max);
            two = random.Next(min, max) + random.Next(min, max);
            three = random.Next(min, max) + random.Next(min, max);
            if (one == value1 + value2) { one++; }
            if (two == value1 + value2) { two++; }
            if (three == value1 + value2) { three++; }

            question.Option1 = one.ToString();
            question.Option2 = two.ToString();
            question.Option3 = three.ToString();
            
            switch (random.Next(1, 4))
            {
                case 1:
                    question.CorrectAnswer = 1;
                    question.Option1 = (value1 + value2).ToString();    
                break;
                case 2:
                    question.CorrectAnswer = 2;
                    question.Option2 = (value1 + value2).ToString();    
                break;
                case 3:
                    question.CorrectAnswer = 3;
                    question.Option3 = (value1 + value2).ToString();    
                break;
            }                                
            return question;
        }

        public static List<Question> BuildQuiz()
        {
            IEnumerable<Question> quiz = Enumerable.Range(1, 10).Select(x => QuizAddition());
            return quiz.ToList();
        }

    }
}

