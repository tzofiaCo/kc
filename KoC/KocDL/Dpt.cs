using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KocDL
{
    public class Dpt
    {
        [Required]
        [DisplayName("שם")]
        public string Title { get; set; }
        [DisplayName("תיאור")]
        public string Desc { get; set; }
        [AllowNull]
        [DisplayName("קונטקסט")]
        public int? Context { get; set; }
        [DisplayName("פעיל")]
        public bool Active { get; set; }
    }

    public class Population:Dpt
    {
        [Required]
        public int PopulationId { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Category : Dpt
    {
        [Required]
        public int CategoryId { get; set; } 
        public List<Course> Courses { get; set; }
    }
    public class OwnerType : Dpt
    {
        [Required]
        public int OwnerTypeId { get; set; }
        public List<Owner> Owners { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
    public class Diploma : Dpt
    {
        [Required]
        public int DiplomaId { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Gender : Dpt
    {
        [Required]
        public int GenderId { get; set; }
        public List<Course> Courses { get; set; }
    }
}
