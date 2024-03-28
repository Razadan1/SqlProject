using Microsoft.EntityFrameworkCore;

namespace SqlProject.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {}

        public DbSet<Contact> Contacts { get; set; } 
    }
}
