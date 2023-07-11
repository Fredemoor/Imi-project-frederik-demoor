using Imi.Project.Pin.Models;
using Imi.Project.Pin.Services;
using Microsoft.AspNetCore.Components;

namespace Imi.Project.Pin.Pages
{
    public partial class Locations
    {
        [Inject]
        private ICrudService<Location> locationApiService { get; set; }

        private Location currentLocation;
        private Location[] locations = new Location[0];
        private string error;

        protected override async Task OnInitializedAsync()
        {
            await Refreshlocations();
        }

        public async Task Refreshlocations()
        {
            locations = (await locationApiService.GetAll()).ToArray();
            this.currentLocation = null;
        }

        public void AddLocation()
        {
            this.currentLocation = new Location();
        }

        public async Task EditLocation(Location item)
        {


            this.currentLocation = await locationApiService.Get(item.Id);
        }

        public async Task SaveLocation(Location item)
        {
            try
            {
                if (currentLocation.Id == null)
                    await locationApiService.Create(currentLocation);
                else
                    await locationApiService.Update(currentLocation);
                await this.Refreshlocations();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }

        public async Task DeleteLocation(Location item)
        {
            try
            {
                await locationApiService.Delete(item.Id);
                await this.Refreshlocations();
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
        }
    }
}
