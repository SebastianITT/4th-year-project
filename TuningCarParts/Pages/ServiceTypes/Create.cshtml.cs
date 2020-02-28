using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TuningCarParts.Data;
using TuningCarParts.Model;
using TuningCarParts.Utility;

namespace TuningCarParts
{
    
    public class CreateModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;
        public ServiceType ServiceType { get; set; }
       
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(ServiceType ServiceType)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.ServiceType.Add(ServiceType);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}