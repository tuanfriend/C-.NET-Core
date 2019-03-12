using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class MyModel
    {

    }

    public class Product
    {
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
    }

    public class User
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public int Age { get; set; }
    }
    public class IndexViewModel
    {
        public Product NewProduct { get; set; }
        public User NewUser { get; set; }
    }
}