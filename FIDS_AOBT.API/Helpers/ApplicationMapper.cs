using AutoMapper;
using FIDS_AOBT.API.Data;
using FIDS_AOBT.API.Models;

namespace FIDS_AOBT.API.Helpers;

public class ApplicationMapper:Profile
{
    public ApplicationMapper()
    {
        CreateMap<CheckinViewTemplate, CheckinViewTemplateModel>().ReverseMap();
    }
}
