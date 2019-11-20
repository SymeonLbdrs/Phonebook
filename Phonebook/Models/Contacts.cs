using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string First_name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Last_name { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = " Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+[0-9]{2}\s+[0-9]{2}\s+[0-9]{7}$", ErrorMessage = "Not a valid phone number")]
        public string Phone_number { get; set; }
    }

}
