using System;
using System.Collections.Generic;
using mathletics.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
// using mathletics.Context;

namespace mathletics
{
    public static class MathleticsData
    {
        public static void CreateQuiz(List<Question> quiz)
        {
            using (var db = new MathleticsContext())
            {                   
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Question");
                foreach(Question question in quiz) {
                    db.Question.Add(question);
                }
                db.SaveChanges();
            }
        }

        public static List<Question> GetQuiz()
        {
            using (var db = new MathleticsContext())
            {
                return db.Question.ToList();
            }
        }
    }
}