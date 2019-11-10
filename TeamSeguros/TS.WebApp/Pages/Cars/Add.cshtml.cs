using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.WebApp.Data;
using TS.WebApp.Models;

namespace TS.WebApp.Pages.Cars
{
    public class AddModel : PageModel
    {
        public CarStore CarStore { get; set; }
        public AddModel(CarStore carStore)
        {
            CarStore = carStore;
        }
        [BindProperty]
        public Car Car { get; set; }

        [BindProperty]
        public Guid CustomerId { get; set; }
        public void OnGet(Guid customerid)
        {
            this.CustomerId = customerid;
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add
            Car.CustomerId = CustomerId;
            CarStore.AddCar(Car);
            return RedirectToPage("./Index");
        }
    }
}