using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookWF
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> contacts => Set<Contact>();
        public ContactContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=contacts.db");
        }

        public async Task<Contact> GetValue(int id)
        {
            Contact? contacts = await this.contacts
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ID == id);
            return contacts;
        }
    }
}
