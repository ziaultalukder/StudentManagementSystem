using SchoolManagement.Model.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model.Models
{
    public class School:IEntityModel, IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool Delete()
        {
            return IsDeleted;
        }
    }
}
