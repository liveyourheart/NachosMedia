﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NachosMedia.Models
{
    public class Format
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte? CategoryId { get; set; }

    }
}