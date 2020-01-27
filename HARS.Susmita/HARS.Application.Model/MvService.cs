using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvService
    {
        public int ServiceId { get; set; }
        public string Service { get; set; }
        public decimal BasePrice { get; set; }
        public int BranchId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string Branch { get; set; }


    }
}
