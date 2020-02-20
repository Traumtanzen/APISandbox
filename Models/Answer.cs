using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISandbox.Models
{
    public class Answer: BaseEntity
    {
        public bool IsCorrect { get; set; }
        public string AnswerText { get; set; }
    }
}
