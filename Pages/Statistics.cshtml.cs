using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CS312CustomWebsite.Pages
{
    public class StatisticsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Looking at the Numbers...";
        }
    }
}
