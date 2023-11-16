using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ITAdminProject.Models
{
    public class FilterLogs
    {

        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("DeviceName")]
        public string DeviceName { get; set; }
        [JsonProperty("Action")]
        public string Action { get; set; }
        [JsonProperty("Duration")]
        public string Duration { get; set; }
    }
}
