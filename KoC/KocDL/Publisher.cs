using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KocDL
{
   public class Publisher
    {
        [Required]
        public int PublisherId { get; set; }
        [Required]
        [DisplayName("שם")]
        public string Name { get; set; }
        [DisplayName("תיאור")]
        public string Desc { get; set; }
        [Required]
        [DisplayName("טלפון")]
        public string Tel { get; set; }
        [Required]
        [DisplayName("כתובת")]
        public string Adress { get; set; }
        [Required]
        [DisplayName("מייל")]
        public string Mail { get; set; }
        //fk to ownertype
        [Required]
        public int OwnerTypeId { get; set; }
        [Required]
        [DisplayName("סוג מפעיל/מפרסם")]
        public OwnerType OwnerType { get; set; }
        public List<Publication> Publications { get; set; }


    }
}
