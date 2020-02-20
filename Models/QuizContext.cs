using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISandbox.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options)
    : base(options)
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Answer> Answers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DELL-SERGEY;Database=Quiz;Integrated Security=True;");
        }
    }
}

