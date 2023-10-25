using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class Dashboard
    {

        public List<Pie> pielist { get; set; }
        public List<Bar> barlist { get; set; }
        public int emp { get; set; }
        public int dev { get; set; }
        public int unalottedcount { get; set; }
        // public string FirstName { get; set; }
        //public int DeviceCount { get; set; }
    }
}
