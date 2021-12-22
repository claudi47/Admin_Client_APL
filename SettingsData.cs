using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin_Client_APL
{
    public class SettingsData
    {
        [JsonPropertyName("max_researches")]
        public int MaxResearch { get; set; }

        [JsonPropertyName("bool_for_all")]
        public bool ResearchForAll { get; set; }

        [JsonPropertyName("username_research")]
        public string? ResearchUsername { get; set; }

        [JsonPropertyName("user_suspended")]
        public string? SuspendingUser { get; set; }

        [JsonPropertyName("period_of_suspension")]
        public DateTime? SuspendingPeriod { get; set; }

        [JsonPropertyName("perma_ban")]
        public bool PermaBan { get; set; }

        [JsonPropertyName("bool_toggle_goldbet")]
        public bool DisableGoldbet { get; set; }

        [JsonPropertyName("bool_toggle_bwin")]
        public bool DisableBwin { get; set; }
    }
}
