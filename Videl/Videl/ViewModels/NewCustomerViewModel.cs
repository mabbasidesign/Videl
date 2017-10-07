using System;
using System.Collections.Generic;
using System.Linq;
using Videl.Models;
using System.Web;

namespace Videl.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipType { get; set; }
        public Customer Customer { get; set; }
    }
}