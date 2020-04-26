using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TuningCarParts.Data;
using TuningCarParts.Model.ViewModel;
using TuningCarParts.Model;

namespace TuningCarParts.Pages.Parts
{
    public class IndexModel : PageModel
    {
        public PartsAndCustomerViewModel Partss { get; set; }
        public class PartsAndCustomerViewModel
        {
            public int Id { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public double Price { get; set; }
            public int Year { get; set; }
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }


    }

}