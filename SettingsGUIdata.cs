using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace Admin_Client_APL
{
    public class SettingsGUIdata
    {
        public string MaxResearch { get; set; }
        public bool ResearchForAll { get; set; }
        public string ResearchUsername { get; set; }

        public string SuspendingUser { get; set; }
        public string SuspendingPeriod { get; set; }

        public bool DisableGoldbet { get; set; }
        public bool DisableBwin { get; set; }

        public SettingsData ConvertToSettingsData()
        {
            return new SettingsData()
            {
                DisableBwin = DisableBwin, DisableGoldbet = DisableGoldbet,
                MaxResearch = MaxResearch == "unlimited" ? -1 : int.Parse(MaxResearch),
                ResearchForAll = ResearchForAll,
                ResearchUsername = ResearchUsername, SuspendingPeriod = SuspendingPeriod,
                SuspendingUser = SuspendingUser
            };
        }
    }
}