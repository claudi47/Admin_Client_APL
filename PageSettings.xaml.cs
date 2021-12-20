using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Admin_Client_APL
{
    public partial class PageSettings : Page
    {
        public List<int> MaxResearch { get; set; }
        public List<string> Period { get; set; }

        public PageSettings()
        {
            InitializeComponent();
            MaxResearch = new List<int>(){ 1, 2, 3, 4, 5, 10 };
            Period = new List<string>(){ "1 day", "3 days", "1 week", "2 weeks", "1 month", "3 months", "6 months", "1 year", "forever" };
        }
    }
}
