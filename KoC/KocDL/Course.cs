using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KocDL
{
   public class Course
    {
        [Required]
        public int CourseID { get; set; }
        //fk to category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //fk to population
        public int PopulationId { get; set; }
        public Population Population { get; set; }
        //fk to gender
        public int GenderId { get; set; }
        
        public Gender Gender { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        //fk to owners
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public string CourseNotes { get; set; }
        //fk to diploma
        public int DiplomaId { get; set; }
        public Diploma Diploma { get; set; }
        [AllowNull]
        public bool MukarLegmulim { get; set; }
        public List<CourseDetails> CourseDetails { get; set; }

    }
    public class CourseDetails
    {
        [Required]
        public int CourseDetailsID { get; set; }
        //fk to courses
        [Required]
        public int CourseId { get; set; }
        [Required]
        public Course Course { get; set; }
        //fk to publication
        [Required]
        public Publication Publication { get; set; }

        [Required]
        public DateTime CourseStartDate { get; set; }
        [Required]
        public DateTime CourseEndDate { get; set; }

        public int CourseFrequency { get; set; }
        public string Notes { get; set; }
        public int CoursePrice { get; set; }
        [Required]
        public bool Active { get; set; }

        


    }
}
