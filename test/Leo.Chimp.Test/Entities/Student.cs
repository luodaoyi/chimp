using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.RegularExpressions;

namespace Leo.Chimp.Test.Entities
{
    [Table("student")]
    public class Student : IEntity
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public Guid school_id { get; set; }
        public DateTime birthday { get; set; }

        public School MySchool { get; set; }
    }
}
