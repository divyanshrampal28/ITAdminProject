using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public partial class GlobalList

    {
        //public string[] GlobalArray { get; set; } = new string[10];
        public List<History> GlobalListofHistory { get; set; } = new List<History>();
    }
}