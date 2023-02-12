using FIDS_AOBT.Model;

namespace FIDS_AOBT_BlazorApp.Services.CheckinViewTemplateService;

public interface ICheckinViewTemplate
{
    
    Task<List<CheckinViewTemplateDto?>> GetChkVT();
    //Get one
    Task<CheckinViewTemplateDto?> GetChkVTOneAsync(int id);
}
