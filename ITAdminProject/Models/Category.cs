using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Category
    {
        public Category()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsArchived { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
