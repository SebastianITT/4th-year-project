using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuningCarParts.Model.ViewModel
{
    public class PartsAndCustomerViewModel
    {
        public ApplicationUser UserObj { get; set; }
        public IEnumerable<Parts> Parts { get; set; }
    }
}
