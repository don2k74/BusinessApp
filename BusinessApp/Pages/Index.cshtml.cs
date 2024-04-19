// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BusinessApp.Pages
{
    public class IndexModel : PageModel
    {
        public required string FullName { get; set; }
        public required string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public required List<string> Languages { get; set; }

        public void OnGet()
        {
            FullName = "Donald Long";
            LinkedInUsername = "donald-long-18b1a2281";
            YearsOfExperience = 1;
            Languages = [
        "C#",
        "HTML",
        "CSS",
        "JavaScript",
        "Java",
        "Python",
        "Lua",
        "TypeScript",
        "GDScript"
      ];
        }
    }
}
