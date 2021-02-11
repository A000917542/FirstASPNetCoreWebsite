using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class Order
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Customer Customer { get; set; }
    }
}
