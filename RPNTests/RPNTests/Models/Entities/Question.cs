using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.Questions")]
    public class Question : IdKeyClass
    {
        public string Text { get; set; }

        public ICollection<Answer> Answers { get; set; }
        //public ICollection<RightAnswer> RightAnswers { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }

        public ICollection<UserTestAnswer> UserTestAnswers { get; set; }
        public ICollection<ActiveTest> ActiveTests { get; set; }




    }
}