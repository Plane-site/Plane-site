using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTest1.Models
{
    public class Tickets
    {
        [Key]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Your EGN need to be 10 characters")]
        public int EGN { get; set; }
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Provide your First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Provide your Second name")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Provide your Last name")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "You need to provide an E-mail.")]
        public string Email { get; set; }
        public string Class { get; set; }
        [ForeignKey("PlaneNumber")]
        public int PlaneNumber { get; set; }
    }
}
