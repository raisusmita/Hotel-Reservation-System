using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string CitizenshipNumber { get; set; }
        public string Nationality { get; set; }
        public int HotelId { get; set; }

        public string Hotel { get; set; }

    }
}
