using System.Collections.Generic;

namespace Imi.Project.Api.Core.Services.Models
{
    public class AuthenticateResultModel
    {
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
