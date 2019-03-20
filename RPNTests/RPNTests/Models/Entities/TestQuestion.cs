using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.TestQuestions")]
    public class TestQuestion : IdKeyClass
    {
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        
        public Test CurrentTest { get; set; }
        public Question CurrentQuestion { get; set; }

    }
}