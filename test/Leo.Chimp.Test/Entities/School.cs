﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Leo.Chimp.Test.Entities
{
    [Table("school")]
    public class School : IEntity
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
    }
}
