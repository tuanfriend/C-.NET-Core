using System;
using System.ComponentModel.DataAnnotations;

namespace FormValidator.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "First Name")] 
        public string Fname { get; set; }
        
        [Required]
        [MinLength(3)]
        [Display(Name = "Last Name")] 
        public string Lname { get; set; }

        // age must be from 18 to 40 only
        [Required]
        [Range(18,40)]
        [Display(Name = "Age")] 
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")] 
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")] 
        public string Password { get; set; }
    }
}