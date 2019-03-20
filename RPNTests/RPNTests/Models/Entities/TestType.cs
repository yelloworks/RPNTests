using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    [Table("dbo.TestTypes")]
    public class TestType:IdKeyClass
    {
        public string Text { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}