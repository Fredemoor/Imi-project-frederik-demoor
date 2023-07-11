using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using System.Collections.ObjectModel;

namespace Imi.Project.Mobile.PageModels
{
    public class KennelListPageModel : FreshBasePageModel
    {


        private ApiLocationService _apiLocationService;

        public KennelListPageModel(ApiLocationService apiLocationService)
        {
            _apiLocationService = apiLocationService;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private bool isCLean;

        public bool IsCLean
        {
            get { return isCLean; }
            set
            {
                isCLean = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<Location> locations;

        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set
            {
                locations = value;
                RaisePropertyChanged();
            }
        }


        private Location selectedLocation;

        public Location SelectedLocation
        {
            get { return null; }
            set
            {
                selectedLocation = value;
                if (selectedLocation != null)
                {
                    CoreMethods.PushPageModel<KennelDetailPageModel>(selectedLocation);
                    RaisePropertyChanged(nameof(selectedLocation));
                }
            }
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            var locations = await _apiLocationService.GetAllAsync();
            Locations = new ObservableCollection<Location>(locations);
        }

    }
}
