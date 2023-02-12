using FIDS_AOBT.Model;
using Microsoft.AspNetCore.Components;
using TelerikBlazorApp.Services.CheckinViewTemplateService;

namespace TelerikBlazorApp.Pages;

public partial class CheckinViewTemplate
{
    [Inject] private ICheckinViewTemplate checkinViewTemplate { get; set; }

    private List<CheckinViewTemplateDto> Tasks;
    protected override async Task OnInitializedAsync()
    {
        Tasks = await checkinViewTemplate.GetChkVT();
    }
}
