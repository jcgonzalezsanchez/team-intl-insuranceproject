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

        public CarStore CarStore { get; set; }
        public List<Car> Cars { get; set; }
        public IndexModel(CarStore carStore)
        {
            CarStore = carStore;
            Cars = CarStore.GetCars();
    }
        public IActionResult OnPostDelete(Guid id)
        {
            CarStore.DeleteCar(id);
            return RedirectToPage();
        }
        public void OnGet()
        {
        }
    }
}
