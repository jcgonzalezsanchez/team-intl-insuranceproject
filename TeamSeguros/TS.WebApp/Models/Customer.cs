using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.WebApp.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentType { get; set; }
        public int Nit { get; set; }
        public DateTime BirthDay { get; set; }
        public string City { get; set; }
        public List<Car> Cars { get; set; }
        public List<Insurance> Insurances { get; set; }

    }
}
