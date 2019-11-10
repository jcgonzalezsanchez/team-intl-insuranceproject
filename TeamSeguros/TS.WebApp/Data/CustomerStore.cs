using Microsoft.EntityFrameworkCore;
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
        internal void EditCustomer(Customer customer)
        {
            Customer currentCustomer = GetCustomerById(customer.Id);
            currentCustomer.Name = customer.Name;
            currentCustomer.LastName = customer.LastName;
            currentCustomer.DocumentType = customer.DocumentType;
            currentCustomer.Nit = customer.Nit;
            currentCustomer.BirthDay = customer.BirthDay;
            currentCustomer.City = customer.City;

            Context.Customer.Update(currentCustomer);
            Context.SaveChanges();
        }
        internal Customer GetCustomerById(Guid id)
        {
            return Context.Customer.FirstOrDefault(x => x.Id == id);
        }
        internal void AddCustomer(Customer customer)
        {
            Context.Customer.Add(customer);
            Context.SaveChanges();
        }
        internal void DeleteCustomer(Guid id)
        {
            var customer = Context.Customer.FirstOrDefault(x => x.Id == id);
            Context.Customer.Remove(customer);
            Context.SaveChanges();
        }
        internal List<Customer> GetCustomers()
        {
            return Context.Customer.Include(x=> x.Cars).ToList();
        }
    }
}
