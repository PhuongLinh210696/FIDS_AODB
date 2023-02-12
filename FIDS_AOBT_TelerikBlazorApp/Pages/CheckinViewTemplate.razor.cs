using FIDS_AOBT.Model;
using FIDS_AOBT_BlazorApp.Services.CheckinViewTemplateService;
using Microsoft.AspNetCore.Components;

namespace FIDS_AOBT_TelerikBlazorApp.Pages;

public partial class CheckinViewTemplate
{
    [Inject] private ICheckinViewTemplate checkinViewTemplate { get; set; }

    private List<CheckinViewTemplateDto> Tasks;
    protected override async Task OnInitializedAsync()
    {
        Tasks = await checkinViewTemplate.GetChkVT();
    }
}
