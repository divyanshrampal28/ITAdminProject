using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InventoryAssignedToNavigation = new HashSet<Inventory>();
            InventoryCreatedByNavigation = new HashSet<Inventory>();
            InventoryUpdatedByNavigation = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<Inventory> InventoryAssignedToNavigation { get; set; }
        public ICollection<Inventory> InventoryCreatedByNavigation { get; set; }
        public ICollection<Inventory> InventoryUpdatedByNavigation { get; set; }
    }
}
