using FIDS_AOBT.API.Models;

namespace FIDS_AOBT.API.Repositories;

public interface ICheckinViewTemplateRepository
{
    public Task<List<CheckinViewTemplateModel>> GetAllAsync();
    public Task<CheckinViewTemplateModel> GetByIdAsync(int id);
    public Task<int> AddCheckinViewTemplateAsync(CheckinViewTemplateModel ckViewTemplate);
    public Task UpdateCheckinViewTemplateAsync(int id, CheckinViewTemplateModel ckViewTemplate);
    public Task DeleteCheckinViewTemplateAsync(int id);
}
