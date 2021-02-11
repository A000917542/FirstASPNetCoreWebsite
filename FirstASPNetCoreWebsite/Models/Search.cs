using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class Search
    {
        [FromQuery(Name = "q")]
        public string q { get; set; } = String.Empty;
    }
}
