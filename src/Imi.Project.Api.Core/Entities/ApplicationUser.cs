using Microsoft.AspNetCore.Identity;
using System;

namespace Imi.Project.Api.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public bool HasApprovedTermsAndConditions { get; set; }
    }
}
