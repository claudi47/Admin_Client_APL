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
    }   
}
