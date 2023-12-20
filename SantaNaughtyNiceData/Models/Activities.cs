﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData.Models
{
    public class Activities
    {
        [Required] 
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
