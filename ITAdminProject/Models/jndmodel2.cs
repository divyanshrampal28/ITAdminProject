using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Jndmodel2
    {

        public IEnumerable<Jnd> listofJnd { get; set; }
        public string DeviceName { get; set; }

        public int CategoryId { get; set; }

        public int? AssignedTo { get; set; }
        public int StatusId { get; set; }


        public int Id { get; set; }
    }
}
