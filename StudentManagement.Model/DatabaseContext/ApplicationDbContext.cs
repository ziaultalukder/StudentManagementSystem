using Microsoft.AspNet.Identity.EntityFramework;
using StudentManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model.DatabaseContext
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(): base("DefaultConnection")
        {
        }
        public DbSet<School> Schools { get; set; }
    }
}
