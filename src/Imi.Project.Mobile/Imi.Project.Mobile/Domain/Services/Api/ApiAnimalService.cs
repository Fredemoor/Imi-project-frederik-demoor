using Imi.Project.Api.Dtos.Animals;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiAnimalService : IAnimalService
    {
        private readonly AppHttpClient httpClient;
        private readonly string baseUri = Constants.BaseUrl;

        public ApiAnimalService(AppHttpClient client)
        {
            httpClient = client;
        }

        public Task<IEnumerable<Animal>> Search(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Animal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Animal>> GetAllAsync()
        {
            var apiAnimals = await httpClient.GetApiResult<List<AnimalDto>>($"{baseUri}/api/animals");

            var animals = new List<Animal>();
            animals.AddRange(apiAnimals.Select(a => new Animal
            {
                Id = a.Id,
                LocationId = a.LocationId,
                BreedId = a.BreedId,
                MediaId = a.MediaId,
                Name = a.Name,
                Description = a.Description,
                Breed = a.Breed,
                Location = a.Location,
                Birthdate = a.BirthDate,
                Gender = a.Gender,
                IsFed = a.IsFed,
                IsWalked = a.IsWalked,
                Media = $"{baseUri}/{a.Media}"
            }));

            return animals;
        }

        public Task<Animal> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> AddAsync(Animal entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Animal> UpdateAsync(Animal animal)
        {
            return await httpClient.PutCallApi<Animal, Animal>($"api/Animals/{animal.Id}", animal);
        }

        public async Task<Animal> DeleteAsync(Guid id)
        {
            return await httpClient.DeleteCallApi<Animal>($"api/Animals/{id}");
        }
    }
}
