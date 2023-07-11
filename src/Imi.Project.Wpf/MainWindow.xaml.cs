using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Enums;
using Imi.Project.Api.Dtos;
using Imi.Project.Api.Dtos.Animals;
using Imi.Project.Api.Dtos.Breeds;
using Imi.Project.Api.Dtos.Locations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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

namespace Imi.Project.Wpf
{

    public partial class MainWindow : Window
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClient;

        public MainWindow(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResetFeedback();
            PopulateGenderCmbBox();
            GetLocations();

            var response = await _httpClient.GetAsync("breeds");
            //_httpClient.PostAsJsonAsync(_httpClient.BaseAddress, response); 

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var breedsResponse = await JsonSerializer.DeserializeAsync<IEnumerable<BreedResponseDto>>(responseStream);

                PopulatebreedListBox(breedsResponse);
                PopulatebreedCmbBox(breedsResponse);
            }
            else
            {
                ShowFeedback(response.ReasonPhrase);
            }
        }

        private async void GetLocations()
        {
            var response = await _httpClient.GetAsync("Locations");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var locationResponse = await JsonSerializer.DeserializeAsync<IEnumerable<LocationResponseDto>>(responseStream);
                PopulateLocationsCmbBox(locationResponse);
            }
            else
            {
                ShowFeedback(response.ReasonPhrase);
            }
        }

        private async void GetAnimalsFromBreedSelection(Guid id)
        {
            ResetFeedback();

            var response = await _httpClient.GetAsync($"breeds/{id}/animals");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var animalsResponse = await JsonSerializer.DeserializeAsync<IEnumerable<AnimalResponseDto>>(responseStream);

                PopulateAnimalsFromBreedInListBox(animalsResponse);
            }

        }

        private void PopulatebreedListBox(IEnumerable<BreedResponseDto> breeds)
        {
            lstBreeds.Items.Clear();
            foreach (var breed in breeds)
            {
                lstBreeds.Items.Add(breed);
            }
        }
        private void PopulateGenderCmbBox()
        {
            foreach (var gender in Enum.GetValues(typeof(Gender)))
            {
                cmbGender.Items.Add(gender);
            };

        }
        private void PopulatebreedCmbBox(IEnumerable<BreedResponseDto> breeds)
        {
            cmbBreed.Items.Clear();
            foreach (var breed in breeds)
            {
                cmbBreed.Items.Add(breed);
            }
        }
        private void PopulateLocationsCmbBox(IEnumerable<LocationResponseDto> locations)
        {
            cmbLocations.Items.Clear();
            foreach (var location in locations)
            {
                cmbLocations.Items.Add(location);
            }
        }
        private void PopulateAnimalsFromBreedInListBox(IEnumerable<AnimalResponseDto> animals)
        {
            lstAnimals.Items.Clear();

            foreach (var animal in animals)
            {
                lstAnimals.Items.Add(animal);
            }
        }
        private void lstBreeds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearAnimalDetails();
            var selection = (BreedResponseDto)lstBreeds.SelectedItem;

            GetAnimalsFromBreedSelection(selection.Id);
        }

        private void lstAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetFeedback();
            var selected = (AnimalResponseDto)lstAnimals.SelectedItem;
            if (selected == null)
            {
                ClearAnimalDetails();
                return;
            }
            ShowAnimalDetails(selected);
        }
       
     
        private void ShowAnimalDetails(AnimalResponseDto animal)
        {
            txtName.Text = animal.Name;
            txtAge.Text =  animal.Age.ToString();
            cmbGender.SelectedItem = animal.Gender;
            cmbBreed.SelectedItem= animal.BreedId;
         
            cmbLocations.SelectedItem = animal.Location;
            txtDescription.Text= animal.Description;
        }
        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbBreed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnPut_Click(object sender, RoutedEventArgs e)
        {
            var response = _httpClient.PutAsJsonAsync("Animals", GetValuesFromInput());
            ShowFeedback(response.Result.ReasonPhrase);
        }

        private  void btnPost_Click(object sender, RoutedEventArgs e)
        {
            var response =  _httpClient.PostAsJsonAsync("Animals", GetValuesFromInput());

            ShowFeedback(response.Result.ReasonPhrase);
        }

        private AnimalRequestDto GetValuesFromInput()
        { 

            AnimalRequestDto dto = new AnimalRequestDto();

            var breed = (BreedResponseDto)cmbBreed.SelectedItem;
            dto.BreedId = breed.Id;

            var location = (LocationResponseDto)cmbLocations.SelectedItem;
            dto.LocationId = location.Id;

            dto.Name = txtName.Text;
            dto.Age = int.Parse(txtAge.Text);
            dto.Gender = (Gender)cmbGender.SelectedItem;
           
            dto.Description = txtDescription.Text;

            return dto;
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selected =(AnimalResponseDto)lstAnimals.SelectedItem;
           var animalId = selected.Id
;        
            var response = _httpClient.DeleteAsync($"animals/{animalId}");
            ShowFeedback(response.Result.ReasonPhrase);
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
        private void ClearAnimalDetails()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbBreed.SelectedIndex = -1;
            cmbLocations.SelectedIndex = -1;
        }
    }
}
