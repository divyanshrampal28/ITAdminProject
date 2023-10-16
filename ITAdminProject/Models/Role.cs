using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Role
    {
        public Role()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
