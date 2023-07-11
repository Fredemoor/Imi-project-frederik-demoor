using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdatePage : ContentPage
    {
        //private readonly MockAnimalService animalService;
        //private Animal currentAnimal;
        //private Gender selectedGender;
        //private IValidator animalValidator;


        public UpdatePage(/*Animal animal*/)
        {
            //animalService = new MockAnimalService();
            //animalValidator = new AnimalValidator();
            InitializeComponent();

            //if(animal != null)
            //{
            //    currentAnimal = animal;
            //}
        }

        //protected override void OnAppearing()
        //{
        //    LoadUpdateState();
        //    base.OnAppearing();
        //}

        //private void btnCamera_Clicked(object sender, EventArgs e)
        //{

        //}

        //private void btnFromFile_Clicked(object sender, EventArgs e)
        //{

        //}

        //private void LoadUpdateState()
        //{
        //    txtName.Text = currentAnimal.Name;
        //    txtDescription.Text = currentAnimal.Description;
        //    txtBreed.Text = currentAnimal.Breed;
        //    genderPicker.SelectedIndex = (int)currentAnimal.Gender;

        //}
        //private void SaveUpdateState()
        //{
        //    currentAnimal.Name = txtName.Text;
        //    currentAnimal.Description = txtDescription.Text;
        //    currentAnimal.Breed = txtBreed.Text;
        //    currentAnimal.Gender = selectedGender;


        //}
        //private async void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    SaveUpdateState();
        //    if (Validate(currentAnimal))
        //    {
        //        await animalService.UpdateAsync(currentAnimal);
        //        await DisplayAlert("Saved", $"Changes for {currentAnimal.Name} have been saved", "ok");
        //        await Navigation.PopAsync();
        //    }
        //}

        //private void genderPicker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var selectedIndex = genderPicker.SelectedIndex;
        //    GetGender(selectedIndex);
        //}
        //private void GetGender(int selectedIndex)
        //{
        //    switch (selectedIndex)
        //    {
        //        case 0:
        //            selectedGender = Gender.Male;
        //            break;
        //        case 1:
        //            selectedGender = Gender.Female;
        //            break;
        //    }
        //}


    }
}