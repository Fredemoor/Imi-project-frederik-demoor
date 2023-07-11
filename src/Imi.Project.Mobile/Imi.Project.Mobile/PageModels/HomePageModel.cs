using FreshMvvm;

namespace Imi.Project.Mobile.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
