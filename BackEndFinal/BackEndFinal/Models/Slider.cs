﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinal.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public string  Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
