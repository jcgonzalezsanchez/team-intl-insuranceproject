using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.WebApp.Data;
using TS.WebApp.Models;

namespace TS.WebApp.Pages.Insurances
{
    public class AddModel : PageModel
    {
        public CarStore CarStore { get; set; }
        public CustomerStore CustomerStore { get; set; }
        public InsuranceStore InsuranceStore { get; set; }
        public AddModel(InsuranceStore insuranceStore, CarStore carStore, CustomerStore customerStore)
        {
            InsuranceStore = insuranceStore;
            CarStore = carStore;
            CustomerStore = customerStore;

        }

        [BindProperty]
        public Guid CarId { get; set; }
        [BindProperty]
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Car Car { get; set; }

        public Insurance Insurance { get; set; } = new Insurance();

        [BindProperty]
        public Double TotalAPagar { get; set; }

        public void OnGet(Guid carid)
        {
            Car = CarStore.GetCarById(carid);
            Customer = CustomerStore.GetCustomerById(Car.CustomerId);
            CarId = carid;
            CustomerId = Car.CustomerId;

            double PrecioBase = 1000000;
            double Incrementociudad = 0; //Aplica un incremento del 10% si es medellín
            double IncrementoModelo = 0; //aplica un incremento del 5% si el modelo del carro es mayor de 10 años
            double IncrementoEdad1 = 0; //Aplica un incremeto del 30% si la edad esta entre los 16 y 25 años
            double IncrementoEdad2 = 0; //Aplica un incremeto del 30% si la edad esta entre los 25 y 40 años

            if (Customer.City == "Medellin")
            {
                Incrementociudad = PrecioBase * 0.1;
            }

            if (DateTime.Today.Year - 10 > Car.Year)
            {
                IncrementoModelo = PrecioBase * 0.05;
            }

            if (DateTime.Today.AddTicks(-Customer.BirthDay.Ticks).Year - 1 > 16 && DateTime.Today.AddTicks(-Customer.BirthDay.Ticks).Year - 1 < 25)
            {
                IncrementoEdad1 = PrecioBase * 0.3;
            }

            if (DateTime.Today.AddTicks(-Customer.BirthDay.Ticks).Year - 1 > 25 && DateTime.Today.AddTicks(-Customer.BirthDay.Ticks).Year - 1 < 40)
            {
                IncrementoEdad2 = PrecioBase * 0.1;
            }

            TotalAPagar = PrecioBase + Incrementociudad + IncrementoModelo + IncrementoEdad1 + IncrementoEdad2;

        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add
            Insurance.CarId = CarId;
            Insurance.CustomerId = CustomerId;
            Insurance.Price = Convert.ToInt32(TotalAPagar);
            InsuranceStore.AddInsurance(Insurance);
            return RedirectToPage("./Index");
        }

    }
}