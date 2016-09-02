using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class Customer
    {
        public int Id { set; get; }
        [Required]
        [StringLength(255)]
        public string Name { set; get; }
        [Display(Name = "Date of Birth")]
        public DateTime? Birthday { set; get; }
        public bool IsSubscribedToLettler { get; set; }
        public MembershipType MembershipeType { get; set; }
        public byte MembershipeTypeId { get; set; }

    }

}