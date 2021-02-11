using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class Customer
    {
        [Key]
        [HiddenInput]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please provide an Email address.")]
        public string Email { get; set; }

        [Display(Name = "Amount Spent in life-time", ShortName = "Amount Spent")]
        [DataType(DataType.Currency)]
        [Editable(false)]
        [Range(0, double.PositiveInfinity, ErrorMessage = "This value is out of range.")]
        public decimal AmountSpent { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
