using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Data;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Contact.Pages.ContactBook
{
    public class IndexModel : PageModel
    {
        private readonly Contact.Data.ApplicationDbContext _db;

        public IndexModel(Contact.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<PhoneContact> Phones { get; set; }

        public async Task OnGet()
        {
            Phones = await _db.Phones.ToListAsync();
        }
    }
}