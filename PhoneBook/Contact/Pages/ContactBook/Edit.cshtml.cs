using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Contact.Pages.ContactBook
{
    public class EditModel : PageModel
    {
        private readonly Contact.Data.ApplicationDbContext _db;

        public EditModel(Contact.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public PhoneContact Phones { get; set; }

        public async Task<IActionResult> OnGetAsync(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            Phones = await _db.Phones.FirstOrDefaultAsync(m => m.Id == Id);

            if(Phones == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int Id)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Phones).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!PhonesExists(Phones.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }

        private bool PhonesExists(int Id)
        {
            return _db.Phones.Any(e => e.Id == Id);
        }
    }
}