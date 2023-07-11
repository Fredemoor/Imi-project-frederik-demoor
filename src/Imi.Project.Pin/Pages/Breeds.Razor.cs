using Imi.Project.Pin.Models;
using Imi.Project.Pin.Services;
using Microsoft.AspNetCore.Components;

namespace Imi.Project.Pin.Pages
{
    public partial class Breeds
    {
        [Inject]
        private ICrudService<Breed> breedService { get; set; }

        public Guid Id { get; private set; }
        private Breed[] breeds;
        private Breed currentBreed;
        private string error;

        protected override async Task OnInitializedAsync()
        {
            await RefreshBreeds();
        }

        public async Task RefreshBreeds()
        {
            breeds = (await breedService.GetAll()).ToArray();
            this.currentBreed = null;
        }

        public void AddBreed()
        {
            this.currentBreed = new Breed();
        }

        public async Task EditBreed(Breed item)
        {
            this.currentBreed = await breedService.Get(item.Id);
        }

        public async Task SaveBreed(Breed item)
        {
            try
            {
                if (currentBreed.Id == null)
                    await breedService.Create(currentBreed);
                else
                    await breedService.Update(currentBreed);
                await RefreshBreeds();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }

        public async Task DeleteBreed(Breed item)
        {
            try
            {
                await breedService.Delete(item.Id);
                await this.RefreshBreeds();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }
    }
}
