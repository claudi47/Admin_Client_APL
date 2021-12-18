using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin_Client_APL
{
    public class Stat1_Data
    {
        [JsonPropertyName("total_users")]
        public int TotalUsers { get; set; }
        [JsonPropertyName("usernames")]
        public List<string> Usernames { get; set; }
    }
}
