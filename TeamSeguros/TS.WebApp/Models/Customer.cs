using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TS.WebApp.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DocumentType { get; set; }
        [Required]
        public int Nit { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string City { get; set; }
        public List<Car> Cars { get; set; }
        public List<Insurance> Insurances { get; set; }

    }
}
