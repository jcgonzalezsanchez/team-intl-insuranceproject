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
    public class EditModel : PageModel
    {
        public CarStore CarStore { get; set; }
        public EditModel(CarStore carStore)
        {
            CarStore = carStore;
        }

        [BindProperty]
        public Car Car { get; set; }

        public void OnGet(Guid id)
        {
            Car = CarStore.GetCarById(id);
        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Edit
            CarStore.EditCar(Car);
            return RedirectToPage("./index");
        }
    }
}