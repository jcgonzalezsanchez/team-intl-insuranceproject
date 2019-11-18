using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TS.WebApp.Data;
using TS.WebApp.Models;

namespace TS.WebApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        
        public CustomerStore CustomerStore { get; set; }
        public Customer Customer { get; set; }
        public CarStore CarStore { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<CustomerCar> CustomersCars { get; set; }
        public IndexModel(CarStore carStore, CustomerStore customerStore)
        {
            CarStore = carStore;
            Cars = CarStore.GetCars();
            CustomerStore = customerStore;
            Customers = CustomerStore.GetCustomers();

        }

        public IActionResult OnPostDelete(Guid id)
        {
            CarStore.DeleteCar(id);
            return RedirectToPage();
        }
        public void OnGet()
        {
            var ListCustomers = from c in Cars
                                join cu in Customers
                                on c.CustomerId equals cu.Id
                                select new CustomerCar
                                {
                                    Id = c.Id,
                                    Name = cu.Name,
                                    LastName = cu.LastName,
                                    Brand = c.Brand,
                                    Model = c.Model,
                                    Year = c.Year,
                                    BirthDay = cu.BirthDay,
                                };
            CustomersCars = ListCustomers.ToList();
        }


    }
}
