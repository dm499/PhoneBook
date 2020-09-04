using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Contact.Pages.ContactBook
{
    public class DeleteModel : PageModel
    {
        private readonly Contact.Data.ApplicationDbContext _db;

        public DeleteModel(Contact.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public PhoneContact Phones { get; set; }

        public async Task<IActionResult> OnGet(int Id)
        {
            Phones = await _db.Phones.FindAsync(Id);

            if(Phones == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            Phones = _db.Phones.Find(Phones.Id);

            if(Phones != null)
            {
                _db.Phones.Remove(Phones);
                _db.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}