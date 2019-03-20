using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.Answers")]
    public class Answer : IdKeyClass
    {
        public string Text { get; set; }
        public int QuestionId { get; set; }

        public ICollection<RightAnswer> RightAnswers { get; set; }
        public Question CurrentQuestion { get; set; }
    }
}