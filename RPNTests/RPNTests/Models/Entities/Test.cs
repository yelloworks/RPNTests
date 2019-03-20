using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPNTests.Models.Entities
{
    [Table("dbo.Tests")]
    public class Test : IdKeyClass
    {
        public DateTime Year { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public bool IsBlocked { get; set; }

        public ICollection<UserTest> UserTests { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }
        public TestType CurrentTestType { get; set; }

    }
}