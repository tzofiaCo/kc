using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("תאריך תחילת פרסום")]
        public DateTime StartPublish { get; set; }
        [DisplayName("תאריך סוף פרסום")]
        public DateTime EndPublish { get; set; }
        [Required]
        [DisplayName("טלפון 1")]
        public string Tel1 { get; set; }
        [DisplayName("טלפון 2")]
        public string Tel2 { get; set; }
        [Required]
        [DisplayName("מייל")]
        public string Mail { get; set; }
        [DisplayName("כתובת אתר")]
        public string WebSite { get; set; }
        [DisplayName("רמת פרסום")]
        [Required]
        public PublishLevel PublishLevel { get; set; }

    }
    public enum PublishLevel
    {
        High = 1,
        Medium = 2,
        Low = 3
    }
}
