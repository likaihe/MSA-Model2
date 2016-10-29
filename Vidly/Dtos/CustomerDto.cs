using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {

        public int Id { set; get; }
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { set; get; }


        //[MoreThan18]
        public DateTime? Birthday { set; get; }

        public bool IsSubscribedToLettler { get; set; }


        public byte MembershipeTypeId { get; set; }
    }
}