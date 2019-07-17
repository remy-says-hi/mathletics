using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace mathletics.Context
{

    public class MathleticsContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<ProblemList> ProblemList { get; set; }
        public DbSet<Question> Question { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("server=localhost;database=mathletics;user=root;password=root;port=8889;");
		}

    }

    public class Player
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }
        public List<Answer> Answer { get; set; } = new List<Answer>();
    }

    public class Answer
    {
        public int Id { get; set; }
        public int Choice { get; set; }
    }


    public class ProblemList 
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }

    public class Question
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public int CorrectAnswer { get; set; }
    }

}