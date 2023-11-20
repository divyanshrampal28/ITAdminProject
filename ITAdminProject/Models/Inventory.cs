using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ITAdminProject.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        [Required]
        public string DeviceName { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAtUtc { get; set; }
        public int? AssignedTo { get; set; }
        [Required]
        public int StatusId { get; set; }

        public Employee AssignedToNavigation { get; set; }
        public Category Category { get; set; }
        public Employee CreatedByNavigation { get; set; }
        public StatusTable Status { get; set; }
        public Employee UpdatedByNavigation { get; set; }

        internal IEnumerable<Jnd> Join(DbSet<Category> cat, Func<object, object> p1, Func<Category, int> p2, Func<object, object, Jnd> p3)
        {
            throw new NotImplementedException();
        }
    }
}
