﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.WebApp.Data;
using TS.WebApp.Models;

namespace TS.WebApp.Pages.Customers
{
    public class EditModel : PageModel
    {
        public CustomerStore CustomerStore { get; set; }
        public EditModel(CustomerStore customerStore)
        {
            CustomerStore = customerStore;
        }
        [BindProperty]
        public Customer Customer { get; set; }
        public void OnGet(Guid id)
        {
            Customer = CustomerStore.GetCustomerById(id);
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Edit
            CustomerStore.EditCustomer(Customer);
            return RedirectToPage("./Index");
        }
    }
}