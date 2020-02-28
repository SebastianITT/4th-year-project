using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuningCarParts.Model.ViewModel
{
    public class UserListViewModel
    {
        public List<ApplicationUser> ApplicationUserList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
