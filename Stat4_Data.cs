using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin_Client_APL
{
    public class Stat4_Data
    {
        [JsonPropertyName("average_researches")]
        public float AverageResearches { get; set; }
    }
}
