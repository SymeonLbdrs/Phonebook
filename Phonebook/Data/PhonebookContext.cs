using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Phonebook.Models
{
    public class PhonebookContext : DbContext
    {
        public PhonebookContext (DbContextOptions<PhonebookContext> options)
            : base(options)
        {
        }

        public DbSet<Phonebook.Models.Contacts> Contacts { get; set; }
    }
}
