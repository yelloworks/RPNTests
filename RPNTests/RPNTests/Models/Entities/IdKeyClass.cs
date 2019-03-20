using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPNTests.Models.Entities
{
    public class IdKeyClass
    {
        [Key]
        public int Id { get; set; }
    }
}