using Imi.Project.Api.Dtos;
using Imi.Project.Api.Dtos.Animals;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http.Headers;
using Imi.Project.Api.Core.Entities;
using System.Windows.Media;

namespace Imi.Project.Wpf.Pri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClient;

        public MainWindow(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/");
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResetFeedback();

            var response = await _httpClient.GetAsync("animals");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var animalsResponse = await JsonSerializer.DeserializeAsync<ApiBaseResponse<IEnumerable<AnimalResponseDto>>>(responseStream);

                PopulateAnimalsInListBox(animalsResponse.Data);
            }
            else
            {
                ShowFeedback(response.ReasonPhrase);
            }
        }

        private void PopulateAnimalsInListBox(IEnumerable<AnimalResponseDto> animals)
        {
            lstAnimals.Items.Clear();
            foreach (var animal in animals)
            {
                lstAnimals.Items.Add(animal);
            }
        }
        private void ShowFeedback(string message)
        {
            lblFeedback.Content = $"Fout: {message}";
            lblFeedback.Background = Brushes.Red;
            lblFeedback.Foreground = Brushes.White;
            lblFeedback.FontWeight = FontWeights.Bold;
        }

        private void ResetFeedback()
        {
            lblFeedback.Content = string.Empty;
            lblFeedback.Background = Brushes.White;
            lblFeedback.Foreground = Brushes.Black;
            lblFeedback.FontWeight = FontWeights.Bold;
        }

    }
}
