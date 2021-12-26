using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Admin_Client_APL
{
    public partial class PageStats : Page
    {
        public PageStats()
        {
            InitializeComponent();
        }

        private async void onClick_Stat1(object sender, RoutedEventArgs e)
        {
            try
            {
                var response = await App.Client.GetFromJsonAsync<Stat1_Data>("http://localhost:8000/bot/stats/?stat=1");
                if (response == null)
                {
                    await Console.Error.WriteLineAsync("Errore nella richiesta stat 1");
                    return;
                }

                TextBoxStats.Text = $"The number of users that make a research are: {response.TotalUsers}\n" +
                                    $"Here there are their names: \n{string.Join("\n", response.Usernames)}";
            }
            catch (HttpRequestException ex)
            {
                await Console.Error.WriteLineAsync($"Errore nella richiesta JSON: {ex}");
                return;
            }
            catch (InvalidOperationException ex)
            {
                await Console.Error.WriteLineAsync($"URI errato: {ex}");
                return;
            }
            catch (TaskCanceledException ex)
            {
                await Console.Error.WriteLineAsync($"Timeout: {ex}");
                return;
            }
            catch (JsonException ex)
            {
                await Console.Error.WriteLineAsync($"Errore nel JSON: {ex}");
                return;
            }
        }

        private async void onClick_Stat2(object sender, RoutedEventArgs e)
        {
            try
            {
                var response = await App.Client.GetFromJsonAsync<Stat2_Data>("http://localhost:8000/bot/stats/?stat=2");
                if (response == null)
                {
                    await Console.Error.WriteLineAsync("Errore nella richiesta stat 2");
                    return;
                }

                TextBoxStats.Text = $"The number of csv files inside the database is: {response.TotalCsv}\n";
            }
            catch (HttpRequestException ex)
            {
                await Console.Error.WriteLineAsync($"Errore nella richiesta JSON: {ex}");
                return;
            }
        }

        private async void onClick_Stat3(object sender, RoutedEventArgs e)
        {
            try
            {
                var response = await App.Client.GetFromJsonAsync<Stat3_Data>("http://localhost:8000/bot/stats/?stat=3");
                if (response == null)
                {
                    await Console.Error.WriteLineAsync("Errore nella richiesta stat 3");
                    return;
                }

                TextBoxStats.Text = $"The number of researches in the Goldbet website is: {response.GoldbetTotal}\n"
                    + $"The number of researches in the Bwin website is: {response.BwinTotal}\n";
            }
            catch (HttpRequestException ex)
            {
                await Console.Error.WriteLineAsync($"Errore nella richiesta JSON: {ex}");
                return;
            }
        }
        private async void onClick_Stat4(object sender, RoutedEventArgs e)
        {
            try
            {
                var response = await App.Client.GetFromJsonAsync<Stat4_Data>("http://localhost:8000/bot/stats/?stat=4");
                if (response == null)
                {
                    await Console.Error.WriteLineAsync("Errore nella richiesta stat 4");
                    return;
                }

                TextBoxStats.Text = $"The average number of research for each user is: {response.AverageResearches}\n";
            }
            catch (HttpRequestException ex)
            {
                await Console.Error.WriteLineAsync($"Errore nella richiesta JSON: {ex}");
                return;
            }
        }
    }   
}
