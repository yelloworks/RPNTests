using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.RightAnswers")]
    public class RightAnswer : IdKeyClass
    {
        //public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        //public Question CurrentQuestion { get; set; }
        public Answer CurrentAnswer { get; set; }
        
    }
}