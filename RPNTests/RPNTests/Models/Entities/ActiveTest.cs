using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.ActiveTest")]
    public class ActiveTest
    {
        //[Key]
        //[Column(Order = 1)]
        public int UserTestId { get; set; }
        //[Key]
        //[Column(Order = 2)]
        public int QuestionNumber { get; set; }
        public int QuestionId { get; set; }

        public UserTest CurrentUserTest { get; set; }
        public Question CurrentQuestion { get; set; }
    }
}