using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.UserTestAnswers")]
    public class UserTestAnswer:IdKeyClass
    {
        public int UserTestId { get; set; }
        public int QuestionId { get; set; }
        public bool IsRight { get; set; }

        public UserTest CurrentUserTest { get; set; }
        public Question CurrentQuestion { get; set; }
    }
}