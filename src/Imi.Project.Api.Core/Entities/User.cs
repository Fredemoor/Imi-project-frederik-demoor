using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Entities
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match")]
        public string ConfirmPassword { get; set; }
    }
}
