using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolManagement.Repository.Base;
using SchoolManagement.Repository.Contracts;
using StudentManagement.Model.Models;

namespace SchoolManagement.Repository
{
    public class SchoolRepository:Repository<School>, ISchoolRepository
    {
        public SchoolRepository(IdentityDbContext db) : base(db)
        {
        }
    }
}
