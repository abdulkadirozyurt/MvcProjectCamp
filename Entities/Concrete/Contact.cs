using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(50)]
        public string UserFirstName { get; set; }
        [StringLength(50)]
        public string UserLastName { get; set; }
        [StringLength(50)]
        public string UserEMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        
        public string Message { get; set; }


    }
}
