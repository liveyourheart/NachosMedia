using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NachosMedia.Models
{
    public class MediaRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public Category Category { get; set; }  

        public Format Format { get; set; }

        public Genre Genre { get; set; }

        public bool IsPublic { get; set; }

        public bool IsAvailable { get; set; }

        public List<ApplicationUser> WaitingList { get; set; }


    }
}