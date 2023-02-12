using FIDS_AOBT.API.Models;
using FIDS_AOBT.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIDS_AOBT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CheckinViewTemplateController : ControllerBase
{
    private readonly ICheckinViewTemplateRepository _checkinViewTemplateRepository;

    public CheckinViewTemplateController(ICheckinViewTemplateRepository checkinViewTemplateRepository)
    {
        _checkinViewTemplateRepository = checkinViewTemplateRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllChkVT()
    {
        try
        {
            return Ok(await _checkinViewTemplateRepository.GetAllAsync());
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetChkVTById(int id)
    {
        var chkVT = await _checkinViewTemplateRepository.GetByIdAsync(id);
        return chkVT == null ? NotFound() : Ok(chkVT);
    }

    [HttpPost]
    //[Authorize]
    public async Task<IActionResult> AddNewChkVT(CheckinViewTemplateModel templateModel)
    {
        try
        {
            var newChkVTId = await _checkinViewTemplateRepository.AddCheckinViewTemplateAsync(templateModel);
            var chkVT = await _checkinViewTemplateRepository.GetByIdAsync(newChkVTId);
            return chkVT == null ? NotFound() : Ok(chkVT);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> UpdateChkVT(int id, CheckinViewTemplateModel templateModel)
    {
        if(id != templateModel.Id)
        {
            return NotFound();
        }
        await _checkinViewTemplateRepository.UpdateCheckinViewTemplateAsync(id, templateModel);
        return Ok();
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteChkVT(int id)
    {
       
        await _checkinViewTemplateRepository.DeleteCheckinViewTemplateAsync(id);
        return Ok();
    }
}
