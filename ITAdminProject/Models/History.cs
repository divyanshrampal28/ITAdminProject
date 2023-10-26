using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string CategoryName { get; set; }
        public string Action { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
    }
}