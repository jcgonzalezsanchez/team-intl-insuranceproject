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
        public InsuranceStore InsuranceStore { get; set; }
        public AddModel(InsuranceStore insuranceStore)
        {
            InsuranceStore = insuranceStore;
        }

        [BindProperty]
        public Insurance Insurance { get; set; }

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
            Insurance.CustomerId = CustomerId;
            InsuranceStore.AddInsurance(Insurance);
            return RedirectToPage("./Index");
        }

    }
}