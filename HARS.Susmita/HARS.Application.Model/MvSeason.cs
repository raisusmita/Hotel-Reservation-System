using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvSeason
    {
        public int SeasonId { get; set; }
        public string Season { get; set; }
        public int SeasonalRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ServiceCategoryId { get; set; }

    }
}
