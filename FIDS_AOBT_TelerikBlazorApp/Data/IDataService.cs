using FIDS_AOBT_TelerikBlazorApp.Models.Employee;
using FIDS_AOBT_TelerikBlazorApp.Models.Sales;
using System.Collections.Generic;

namespace FIDS_AOBT_TelerikBlazorApp.Data
{
    public interface IDataService
    {
        List<Employee> GetEmployees();
        IEnumerable<Sale> GetSales();
        List<Team> GetTeams();
    }
}
