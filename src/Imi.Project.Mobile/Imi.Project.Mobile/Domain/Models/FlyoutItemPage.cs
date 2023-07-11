using System;

namespace Imi.Project.Mobile.Domain.Models
{
    public class FlyoutItemPage
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetPage { get; set; }
    }
}
