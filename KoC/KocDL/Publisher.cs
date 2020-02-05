using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public string Desc { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Mail { get; set; }
        //fk to ownertype
        [Required]
        public int OwnerTypeId { get; set; }
        [Required]
        public OwnerType OwnerType { get; set; }
        public List<Publication> Publications { get; set; }


    }
}
