using System;

namespace Imi.Project.Mobile.Domain.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public bool HasAcceptedTermsAndConditions { get; set; }

        //registrationDto.BirthDate,
        //registrationDto.HasAcceptedTermsAndConditions

    }
}
