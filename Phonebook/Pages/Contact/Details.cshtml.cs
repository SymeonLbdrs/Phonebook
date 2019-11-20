using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Phonebook.Models;

namespace Phonebook.Pages.Contact
{
    public class DetailsModel : PageModel
    {
        private readonly Phonebook.Models.PhonebookContext _context;

        public DetailsModel(Phonebook.Models.PhonebookContext context)
        {
            _context = context;
        }

        public Contacts Contacts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contacts = await _context.Contacts.FirstOrDefaultAsync(m => m.ID == id);

            if (Contacts == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
