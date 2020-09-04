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
    public class DetailsModel : PageModel
    {
        private readonly Contact.Data.ApplicationDbContext _db;

        public DetailsModel(Contact.Data.ApplicationDbContext db)
        {
            _db = db;
        }

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
    }
}