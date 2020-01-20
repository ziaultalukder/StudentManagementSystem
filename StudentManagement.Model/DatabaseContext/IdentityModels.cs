using Microsoft.AspNet.Identity.EntityFramework;
using StudentManagement.Model.Models;
using System.Data.Entity;

namespace StudentManagement.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    //public class ApplicationDbContext : DbContext
    //{
    //    public ApplicationDbContext(): base("DefaultConnection")
    //    {
    //    }
    //    public DbSet<School> Schools { get; set; }
    //}
}