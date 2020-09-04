using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Contact.Pages.ContactBook
{
    public class CreateModel : PageModel
    {
        private readonly Contact.Data.ApplicationDbContext _db;

        public CreateModel(Contact.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PhoneContact Phones { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Phones.AddAsync(Phones);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}