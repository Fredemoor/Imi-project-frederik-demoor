using Microsoft.AspNetCore.Components;

namespace Imi.Project.Pin.Concept.Quiz.Components
{
    public partial class OptionCard
    {
        [Parameter]
        public string Option { get; set; } /*= string.Empty;*/
        [Parameter]
        public EventCallback<string> OnOptionSelected { get; set; }

        protected async void SelectOption()
        {
            await OnOptionSelected.InvokeAsync(Option);
        }
    }
}
