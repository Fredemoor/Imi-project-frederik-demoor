using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Dtos.Accounts
{
    public class AccountsRegisterRequestDto : AccountsLoginRequestDto
    {
        [Required]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Must accept the terms and conditions")]
        public bool HasAcceptedTermsAndConditions { get; set; }
    }
}
