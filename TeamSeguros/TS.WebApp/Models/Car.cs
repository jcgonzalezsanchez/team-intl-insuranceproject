using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TS.WebApp.Models
{
    public class Car
    {
        public Car()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        public string Brand { get; set; }

        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
