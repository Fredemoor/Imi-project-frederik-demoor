using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;

namespace Imi.Project.Mobile.PageModels
{
    public class KennelDetailPageModel : FreshBasePageModel
    {

        public Location SelectedLocation { get; set; }
        private ApiAnimalService _apiAnimalService;

        public KennelDetailPageModel(ApiAnimalService apiAnimalService)
        {
            _apiAnimalService = apiAnimalService;
        }


        #region Properties//////////////////

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                capacity = value;
                RaisePropertyChanged(nameof(Capacity));
            }
        }


        private bool isFull;

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                isFull = value;
                RaisePropertyChanged(nameof(IsFull));
            }
        }

        private bool isCLean;
        public bool IsCLean
        {
            get { return isCLean; }
            set
            {
                isCLean = value;
                RaisePropertyChanged(nameof(IsCLean));
            }
        }

        #endregion

        public override void Init(object initData)
        {
            base.Init(initData);
            SelectedLocation = (Location)initData;
            LoadKennelProps();
        }

        private void LoadKennelProps()
        {
            Name = SelectedLocation.Name;
            Capacity = SelectedLocation.Capacity;
            IsFull = SelectedLocation.IsFull;
            isCLean = SelectedLocation.IsClean;
        }
    }
}
