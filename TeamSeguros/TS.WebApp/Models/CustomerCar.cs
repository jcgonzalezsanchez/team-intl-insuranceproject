using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.WebApp.Models
{
    public class CustomerCar
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
