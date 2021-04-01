using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class OrderLine
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }

        [ForeignKey("Product")]
        [Required]
        public int ProductID { get; set; }

        [ForeignKey("Order")]
        [Required]
        public int OrderID { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public int Quantity { get; set; }

        public decimal LinePrice => Product.Price * Quantity;

        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
