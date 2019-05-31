﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Contact Contact { get; set; }
        public void OnGet()
        {
            Message = "Your contact page.";
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                return new RedirectToPageResult("Confirmation", "Contact");
            }

            return Page();
        }

        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            return new RedirectToPageResult("Confirmation", "Subscribe");
        }
    }
}