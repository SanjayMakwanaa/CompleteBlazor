using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudblazorDemo.CRUD.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
         public string State { get; set; }
        public string City { get; set; }
    }
}
