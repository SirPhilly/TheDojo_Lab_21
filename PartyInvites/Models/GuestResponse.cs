using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage ="Please enter your email address")]
        public string email { get; set; }
        [Required(ErrorMessage ="Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage ="Which class are you interested in ")]
        public bool? WillAttend { get; set; }
        [Required(ErrorMessage ="Have you done any coding in the past?")]
        public bool? experience { get; set; }
        [Required(ErrorMessage ="Are you a coding Warrior?")]
        public bool isCodingWarrior { get; set; }
        [Required(ErrorMessage ="Please select a gender")]
        public string Gender { get; set; }
    }
}