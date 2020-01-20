using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Repository.Contracts;
using StudentManagement.BLL.Base;
using StudentManagement.BLL.Contracts;
using StudentManagement.Model.Models;

namespace StudentManagement.BLL
{
    public class SchoolManager:Manager<School>, ISchoolManager
    {
        protected ISchoolRepository _SchoolRepository;
        public SchoolManager(ISchoolRepository repository) : base(repository)
        {

        }
    }
}
