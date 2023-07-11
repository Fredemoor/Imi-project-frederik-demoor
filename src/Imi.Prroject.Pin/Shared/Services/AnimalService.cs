using Imi.Project.Pin.Data.Enums;
using Imi.Prroject.Pin.Shared.Interfaces;
using Imi.Prroject.Pin.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Prroject.Pin.Shared.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly HttpClient _httpClient;
        public AnimalService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public List<Animal> Animals { get; set; } = new List<Animal>();
   
        public Task<Animal> GetAnimalById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAnimals()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Animal>>("api/animals");
            if (result != null)
                Animals = result;
        }
    }
}
