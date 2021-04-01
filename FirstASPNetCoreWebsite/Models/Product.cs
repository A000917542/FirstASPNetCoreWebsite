using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class Product
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity, ErrorMessage = "This value is out of range.")]
        public decimal Price { get; set; }
    }
}
