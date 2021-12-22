using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace Admin_Client_APL
{
    public class SettingsGUIdata
    {
        public string? MaxResearch { get; set; }
        public bool ResearchForAll { get; set; }
        public string? ResearchUsername { get; set; }

        public string? SuspendingUser { get; set; }
        public string? SuspendingPeriod { get; set; }

        public bool DisableGoldbet { get; set; }
        public bool DisableBwin { get; set; }

        public SettingsData ConvertToSettingsData() => new()
        {
            DisableBwin = DisableBwin,
            DisableGoldbet = DisableGoldbet,
            MaxResearch = MaxResearch != "unlimited" ? int.Parse(MaxResearch ?? "0", NumberStyles.Integer, NumberFormatInfo.InvariantInfo) : -1,
            ResearchForAll = ResearchForAll,
            ResearchUsername = ResearchUsername == string.Empty ? null : ResearchUsername,
            SuspendingPeriod = SuspendingPeriod switch {
                "1 day" => DateTime.Today.AddDays(1),
                "3 days" => DateTime.Today.AddDays(3),
                "1 week" => DateTime.Today.AddDays(7),
                "2 weeks" => DateTime.Today.AddDays(7 * 2),
                "1 month" => DateTime.Today.AddMonths(1),
                "3 months" => DateTime.Today.AddMonths(3),
                "6 months" => DateTime.Today.AddMonths(6),
                "1 year" => DateTime.Today.AddYears(1),
                _ => null
            },
            PermaBan = SuspendingPeriod == "forever",
            SuspendingUser = SuspendingUser == string.Empty ? null : SuspendingUser
        };
    }
}