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
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Visible;

        }
    }

    public class InfoBody
    {
        [JsonProperty("start_date")]
        public DateTime startDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime endDate { get; set; }

        [JsonProperty("api_key")]
        public string apiKey { get; set; }

        public override string ToString()
        {
            return $"{startDate}:{endDate}:{apiKey}";
        }
    }

    public class Asteroids
    {

        [JsonProperty("asteroid_id")]
        public int asteroidID { get; set; }

        [JsonProperty("api_key")]
        public string apiKey { get; set; }
    }

    class AsteroidList
    {
        static async void Main(string[] args)
        {
            InfoBody asteroid = new InfoBody
            {
                startDate = DateTime.Now,
                endDate = DateTime.FromOADate(7),
                apiKey = "Jyu8jIcUODutReToMHeFLFbta4iCYkZw8UGgMtzk"
            };

            var asteroidJSON = JsonConvert.SerializeObject(asteroid);

            HttpContent content = new StringContent(asteroidJSON, Encoding.UTF8, "https://api.nasa.gov/neo/rest/v1/neo/");

            HttpClient htc = new HttpClient();

            try
            {
                HttpResponseMessage response = await htc.PostAsync("https://api.nasa.gov/neo/rest/v1/neo/browse/", content);

                Console.WriteLine("Headers");
                foreach (KeyValuePair<string, IEnumerable<string>> v in response.Headers )
                {
                    Console.Write($"Klíč {v.Key}, Hodnota: ");
                    foreach (var t in v.Value)
                    {
                        Console.Write($"{t}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"\nÚspěch: {response.IsSuccessStatusCode} Status: {response.StatusCode}");

                Console.WriteLine(response);
            }

            catch (HttpRequestException hre)
            {
                Console.WriteLine("Chyba: Server neodpovídá" + hre);
            }
            
        }
    }

    public class Content : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(text)); }
        }

    }


}
