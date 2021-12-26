using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin_Client_APL
{
    public class Stat3_Data
    {
        [JsonPropertyName("bwin_total")]
        public int BwinTotal { get; set; }
        [JsonPropertyName("goldbet_total")]
        public int GoldbetTotal { get; set; }
    }
}
