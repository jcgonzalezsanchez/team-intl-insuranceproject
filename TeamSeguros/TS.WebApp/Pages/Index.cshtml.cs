using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TS.WebApp.Data;
using TS.WebApp.Models;

namespace TS.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IConfiguration Configuration { get; set; }

        public CustomerStore CustomerStore { get; set; }

        public CarStore CarStore { get; set; }

        public List<Customer> Customers { get; set; }

        public IndexModel(IConfiguration configuration, CustomerStore customerStore, CarStore carStore)
        {
            Configuration = configuration;
            CustomerStore = customerStore;
            Customers = CustomerStore.GetCustomers();

        }
        public void OnGet()
        {

        }
    }
}
