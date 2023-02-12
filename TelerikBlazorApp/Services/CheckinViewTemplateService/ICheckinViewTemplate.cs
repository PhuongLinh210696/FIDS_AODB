using FIDS_AOBT.Model;

namespace TelerikBlazorApp.Services.CheckinViewTemplateService;

public interface ICheckinViewTemplate
{
    Task<List<CheckinViewTemplateDto?>> GetChkVT();
    //Get one
    Task<CheckinViewTemplateDto?> GetChkVTOneAsync(int id);
}
