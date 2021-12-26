using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin_Client_APL
{
    public class Stat2_Data
    {
        [JsonPropertyName("total_csv_files")]
        public int TotalCsv { get; set; }
    }
}
