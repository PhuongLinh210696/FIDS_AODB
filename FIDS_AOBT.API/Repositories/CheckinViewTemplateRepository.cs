using AutoMapper;
using FIDS_AOBT.API.Data;
using FIDS_AOBT.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FIDS_AOBT.API.Repositories;

public class CheckinViewTemplateRepository : ICheckinViewTemplateRepository
{
    private readonly FidsAobtContext _context;
    private readonly IMapper _mapper;

    public CheckinViewTemplateRepository(FidsAobtContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<int> AddCheckinViewTemplateAsync(CheckinViewTemplateModel ckViewTemplate)
    {
        var newChkVT = _mapper.Map<CheckinViewTemplate>(ckViewTemplate);
        _context.CheckinViewTemplates.Add(newChkVT);
        await _context.SaveChangesAsync();

        return newChkVT.Id;
    }

    public async Task DeleteCheckinViewTemplateAsync(int id)
    {
        var chkVT = _context.CheckinViewTemplates.SingleOrDefault(c => c.Id == id);
        if(chkVT != null)
        {
            _context.CheckinViewTemplates.Remove(chkVT);
            await _context.SaveChangesAsync();
        }
        
    }

    public async Task<List<CheckinViewTemplateModel>> GetAllAsync()
    {
        var chkVT = await _context.CheckinViewTemplates.ToListAsync();
        return _mapper.Map<List<CheckinViewTemplateModel>>(chkVT);
    }

    public async Task<CheckinViewTemplateModel> GetByIdAsync(int id)
    {
        var chkVT = await _context.CheckinViewTemplates.FindAsync(id);
        return _mapper.Map<CheckinViewTemplateModel>(chkVT);
    }

    public async Task UpdateCheckinViewTemplateAsync(int id, CheckinViewTemplateModel ckViewTemplate)
    {
        if (id == ckViewTemplate.Id)
        {
            var updateChkVT = _mapper.Map<CheckinViewTemplate>(ckViewTemplate);
            _context.CheckinViewTemplates.Update(updateChkVT);
            await _context.SaveChangesAsync();
        }
    }
}
