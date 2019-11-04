using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.WebApp.Data
{
    public class CarStore
    {
        public TSContext Context { get; set; }
        public CarStore(TSContext context)
        {
            Context = context;
        }
    }
}
