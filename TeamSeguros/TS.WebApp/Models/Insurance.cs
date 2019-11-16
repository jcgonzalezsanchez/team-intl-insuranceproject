using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.WebApp.Models
{
    public class Insurance
    {
        public Insurance()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int Price { get; set; }

    }
}
