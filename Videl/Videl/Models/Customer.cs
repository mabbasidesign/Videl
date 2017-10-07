using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Videl.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? BirthDay { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "MemberShip Type")]
        public byte MemberShipTypeId { get; set; }
    }
}