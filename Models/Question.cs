using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISandbox.Models
{
    public class Question : BaseEntity
    {
        public bool IsHard { get; set; }
        public string UrlToImage { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
