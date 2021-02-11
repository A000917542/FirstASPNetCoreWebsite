using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using FirstASPNetCoreWebsite.Models;


namespace FirstASPNetCoreWebsite.Pages
{
    public class NewPageModel : PageModel
    {
        public void OnGet()
        {
            //var x = Request;
            //var y = Response;

            //if (!String.IsNullOrEmpty(q))
            //{

                // Response.Redirect("https://www.google.ca/search?q=" + Request.Query["q"]);
                // Response.Headers.Add("q-value", new StringValues("" + Request.Query["q"]));
                //Response.Headers.Add("Location", new StringValues("https://www.google.ca/search?q=" + Request.Query["q"]));
                //Response.StatusCode = 302;
                // ViewData["Q"] = Request.Query["q"];
            //}
        }

        public void OnPost()
        {

        }

        [FromForm]
        public Customer Customer { get; set; }
    }
}
