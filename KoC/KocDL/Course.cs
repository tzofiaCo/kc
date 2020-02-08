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
        public int CourseID { get; set; }
        //fk to category
        public int CategoryId { get; set; }
        public Category Category;
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
        
        public int CourseDetailsID { get; set; }
        //fk to courses
        
        public int CourseId;
        
        public Course Course;

        //fk to publication
        
        public Publication Publication { get; set; }
        
        
        public DateTime CourseStartDate { get; set; }
        
        public DateTime CourseEndDate { get; set; }
        
        public string CourseFrequency { get; set; }
        public string Notes { get; set; }
        public int CoursePrice { get; set; }
        public bool Active { get; set; }

        


    }
}
