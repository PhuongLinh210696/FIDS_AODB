using FIDS_AOBT.Model;

namespace FIDS_AOBT_BlazorApp.Services.CheckinViewTemplateService;

public class CheckinViewTemplate : ICheckinViewTemplate
{
    private readonly HttpClient _httpClient;


    public CheckinViewTemplate(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    //public List<CheckinViewTemplateDto> checkinViewTemplateDtos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public async Task<List<CheckinViewTemplateDto?>> GetChkVT()
    {
        var result = await _httpClient.GetFromJsonAsync<List<CheckinViewTemplateDto>>("api/CheckinViewTemplate");
        return result;
    }

   


    public Task<CheckinViewTemplateDto?> GetChkVTOneAsync(int id)
    {
        throw new NotImplementedException();
    }

    
}
