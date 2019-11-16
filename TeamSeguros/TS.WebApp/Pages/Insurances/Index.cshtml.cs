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
    public class IndexModel : PageModel
    {
        public InsuranceStore InsuranceStore { get; set; }
        public List<Insurance> Insurances { get; set; }
        public IndexModel(InsuranceStore insuranceStore)
        {
            InsuranceStore = insuranceStore;
            Insurances = InsuranceStore.GetInsurances();
        }
        public IActionResult OnPostDelete(Guid id)
        {
            InsuranceStore.DeleteInsurance(id);
            return RedirectToPage();
        }
        public void OnGet()
        {
        }
    }
}
