﻿using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAtUtc { get; set; }
        public int AssignedTo { get; set; }
        public int StatusId { get; set; }

        public Employee AssignedToNavigation { get; set; }
        public Category Category { get; set; }
        public Employee CreatedByNavigation { get; set; }
        public StatusTable Status { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
