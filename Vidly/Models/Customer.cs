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
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { set; get; }

        [Display(Name = "Date of Birth")]
        //[MoreThan18]
        public DateTime? Birthday { set; get; }

        public bool IsSubscribedToLettler { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipeType { get; set; }

        public byte MembershipeTypeId { get; set; }

    }

}