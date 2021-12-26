using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Printing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Admin_Client_APL
{
    public partial class PageSettings : Page
    {
        // ObservableCollection represents a dynamic data that provides notification when items are added, deleted or updated
        public ObservableCollection<string> MaxResearch { get; set; }
        public ObservableCollection<string> Period { get; set; }

        public SettingsGUIdata SettingGuiData { get; set; }

        public PageSettings()
        {
            MaxResearch = new ObservableCollection<string>() { "1", "2", "3", "4", "5", "10", "unlimited" };
            Period = new ObservableCollection<string>()
                { "1 day", "3 days", "1 week", "2 weeks", "1 month", "3 months", "6 months", "1 year", "forever" };
            SettingGuiData = new SettingsGUIdata();
            InitializeComponent();
        }

        private async void onClick_Apply(object sender, RoutedEventArgs e)
        {
            // Conversion of the data present in the GUI in the format of data to send to the server
            var instanceOfSettingsData = SettingGuiData.ConvertToSettingsData();
            try
            {
                // This function wants a StringClass object, where we pass a JsonSerializer to serialize the data to send, the encoding and the content type
                var response =
                    await App.Client.PostAsync("http://localhost:8000/bot/settings/", 
                        new StringContent(JsonSerializer.Serialize(instanceOfSettingsData), Encoding.UTF8, "application/json"));
                if (!response.IsSuccessStatusCode)
                {
                    await Console.Error.WriteLineAsync("Errore nella response!");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}