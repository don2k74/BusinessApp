using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusinessApp.Pages
{
    public class Project
    {
        public string Title { get; set; } = "Title";
        public string Description { get; set; } = "Description";
        public int Year { get; set; }
    }
}
