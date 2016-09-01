using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingupFee { get; set; }
        public byte DurationMonth { get; set; }
        public byte Discount { get; set; }
        public String Nmae { get; set; }
    }
}