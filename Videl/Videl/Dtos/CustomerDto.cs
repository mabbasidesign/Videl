using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videl.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        public byte MemberShipTypeId { get; set; }

        //        [Min18YearsIfAMember]
        public DateTime? BirthDay { get; set; }
    }
}