using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KocDL
{
    public class Publication
    {
        [Required]
        public int PublicationID { get; set; }
        //fk to coursesdetails
        [Required]
        //1-1 to course details
        public int CourseDetailsId { get; set; }
        public CourseDetails CourseDetails { get; set; }
        //fk to publisher
        [Required]
        public int PublisherID { get; set; }
        [Required]
        public Publisher Publisher { get; set; }
        [Required]
        public DateTime StartPublish { get; set; }
        public DateTime EndPublish { get; set; }
        [Required]
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        [Required]
        public string Mail { get; set; }
        public string WebSite { get; set; }

    }
}
