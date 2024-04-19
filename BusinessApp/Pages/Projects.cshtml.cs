using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusinessApp.Pages
{
    public class ProjectsModel : PageModel
    {

        public List<Project> Projects { get; set; }
        public ProjectsModel()
        {
            Projects = [];
        }
        public string GithubUsername { get; set; } = "don2k74";

        public void OnGet()
        {
            GithubUsername = "don2k74";
            Projects = [
                new Project()
                {
                    Title = "Animated Business Card",
                    Description = "An animated business card I created Using Canva.",
                    Year = 2023
                },
                new Project()
                {
                    Title = "Animated Logo",
                    Description = "An animated logo I created using Canva.",
                    Year = 2023
                },
                new Project()
                {
                    Title = "Match Game",
                    Description = "A game where you clear blocks of 3 or more of the same color and try to clear the board. I am still developing it, adding features, levels, game boosts and other improvements.",
                    Year = 2024
                },
                new Project ()
                {
                    Title = "Ferris Wheel",
                    Description = "A ferris wheel that rotates just like a real one that I am planning on updating the graphics and making it a photo album.",
                    Year = 2024
                }
            ];
        }
    }
}