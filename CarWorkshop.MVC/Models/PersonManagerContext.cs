using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.MVC.Models
{
    public class PersonManagerContext : DbContext
    {
        public PersonManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set;}
    }
}
