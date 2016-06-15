using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NachosMedia.Models
{
    public class Library
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string AdminName { get; set; }

        public string Description { get; set; }

        public bool IsPublic { get; set; }

        public IEnumerable<MediaRecord> MediaRecords { get; set; }

        
    }
}