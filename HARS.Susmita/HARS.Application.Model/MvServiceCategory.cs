using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvServiceCategory
    {
        public int ServiceCategoryId { get; set; }
        public string ServiceCategory { get; set; }
        public int HotelId { get; set; }
        public string Hotel { get; set; }

    }
}
