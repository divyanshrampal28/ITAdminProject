using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class StatusTable
    {
        public StatusTable()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
