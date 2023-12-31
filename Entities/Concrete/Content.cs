﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string Text { get; set; }
       
        public DateTime Date { get; set; }
        


        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }



        public int? WriterId { get; set; }      // ? ---> nullable 
        public virtual Writer Writer { get; set; }


    }
}
