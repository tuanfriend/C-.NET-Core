using System;
using System.ComponentModel.DataAnnotations;

namespace DsurveyProj.Models
{
    public class Survey{
        [Required]
        [MinLength(2)]
        [Display(Name = "Name")] 
        public string name {get;set;}

        [Required]
        [Display(Name = "Location")] 
        public string local {get;set;}

        [Required]
        [Display(Name = "Language")] 
        public string lang {get;set;}

        [MinLength(20)]
        [Display(Name = "Comment")] 
        public string cm {get;set;}
    }
}