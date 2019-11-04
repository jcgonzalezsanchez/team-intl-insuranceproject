using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TS.WebApp.Models;

namespace TS.WebApp.Data
{
    public class CustomerStore
    {
        public TSContext Context { get; set; }
        public CustomerStore(TSContext context)
        {
            Context = context;
        }

        internal List<Customer> GetCustomers()
        {
            return Context.Customer.ToList(); //Falta hacer la relación con Car "return Context.Customer.Include(x=> x.Cars).ToList();"
        }

        internal void DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
