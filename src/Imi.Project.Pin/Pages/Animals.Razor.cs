using Imi.Project.Pin.Models;
using Imi.Project.Pin.Services;
using Microsoft.AspNetCore.Components;

namespace Imi.Project.Pin.Pages
{
    public partial class Animals
    {
        [Inject]
        private ICrudService<Animal> animalService { get; set; }

        [Inject]
        private ICrudService<Location> locationApiService { get; set; }

        public Guid Id { get; private set; }
        private Animal currentAnimal;
        private Animal[] animals;
        private Location[] availableLocations;
        private string error;
        protected override async Task OnInitializedAsync()
        {
            await RefreshAnimals();
        }
        public async Task RefreshAnimals()
        {
            animals = (await animalService.GetAll()).ToArray();
            this.currentAnimal = null;
        }
        public async Task AddAnimal()
        {
            this.availableLocations = (await locationApiService.GetAll()).ToArray();
            this.currentAnimal = new Animal();
        }
        public async Task EditAnimal(Animal animal)
        {
            this.availableLocations = (await locationApiService.GetAll()).ToArray();
            this.currentAnimal = await animalService.Get(animal.Id);
        }
        public async Task SaveAnimal(Animal animal)
        {
            try
            {
                if (currentAnimal.Id == null)
                {
                    await animalService.Create(currentAnimal);
                }
                else
                {
                    await animalService.Update(currentAnimal);
                }
                await this.RefreshAnimals();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }


        public async Task DeleteAnimal(Animal animal)
        {
            try
            {
                await animalService.Delete(animal.Id);
                await this.RefreshAnimals();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }
    }
}
