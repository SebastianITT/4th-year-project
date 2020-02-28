using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TuningCarParts.Data;
using TuningCarParts.Model;
using TuningCarParts.Model.ViewModel;
using TuningCarParts.Utility;

namespace TuningCarParts.Pages.Users
{
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public UserListViewModel UserListVM { get; set; }

        public async Task<IActionResult> OnGet(int productPage = 1, string searchEmail = null, string searchName = null, string searchPhone = null)
        {
            UserListVM = new UserListViewModel()
            {
                ApplicationUserList = await _db.ApplicationUser.ToListAsync()
            };
            StringBuilder param = new StringBuilder();
            param.Append("/Users?productPage=:");
            param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }
            param.Append("&searchEmail=");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }
            param.Append("&searchPhone=");
            if (searchPhone != null)
            {
                param.Append(searchPhone);
            }
            if (searchEmail != null)
            {
                UserListVM.ApplicationUserList = await _db.ApplicationUser.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower())).ToListAsync();
            }
            else
            {
                if (searchName != null)
                {
                    UserListVM.ApplicationUserList = await _db.ApplicationUser.Where(u => u.Name.ToLower().Contains(searchName.ToLower())).ToListAsync();
                }
                else
                {
                    if (searchPhone != null)
                    {
                        UserListVM.ApplicationUserList = await _db.ApplicationUser.Where(u => u.PhoneNumber.ToLower().Contains(searchPhone.ToLower())).ToListAsync();
                    }
                }
            }



            var count = UserListVM.ApplicationUserList.Count;
            UserListVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage =SD.PaginationUserPage,
                TotalItems = count,
                urlParam = param.ToString()
        };
            UserListVM.ApplicationUserList = UserListVM.ApplicationUserList.OrderBy(p => p.Email)
                .Skip((productPage - 1) * SD.PaginationUserPage)
                .Take(SD.PaginationUserPage).ToList();

            return Page();
        }
    }
}