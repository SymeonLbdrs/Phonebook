using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Phonebook.Models;

namespace Phonebook.Pages.Contact
{
    public class IndexModel : PageModel
    {
        private readonly Phonebook.Models.PhonebookContext _context;

        public IndexModel(Phonebook.Models.PhonebookContext context)
        {
            _context = context;
        }

        public IList<Contacts> Contacts { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }




        
        
            public async Task OnGetAsync()
            {
                var movies = from m in _context.Contacts
                             select m;
               
                if (!string.IsNullOrEmpty(SearchString))
                {
                    movies = movies.Where(s => s.First_name.Contains(SearchString));
                }
               

                Contacts = await movies.ToListAsync();
            } 
        

    }
}
