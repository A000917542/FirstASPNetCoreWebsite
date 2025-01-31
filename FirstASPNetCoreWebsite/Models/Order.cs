﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstASPNetCoreWebsite.Models
{
    public class Order
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }

        [ForeignKey("Customer")]
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;


        public Customer Customer { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
