using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public class User
    {

        [JsonProperty("Email")]
        public string Email { get; set; }

    }
}
