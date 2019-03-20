using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.UserTests")]
    public class UserTest :IdKeyClass
    {
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
        public DateTime EndDate { get; set; }
        public int TestId { get; set; }

        public ICollection<ActiveTest> ActiveTests { get; set; }
        public ICollection<UserTestAnswer> UserTestAnswers { get; set; }
        public Test CurrentTest { get; set; }

    }
}