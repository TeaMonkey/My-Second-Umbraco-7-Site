using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "The first name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("E-mail address")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        public string Email { get; set; }

        [DisplayName("Phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "A message is required")]
        public string Message { get; set; }
    }
}