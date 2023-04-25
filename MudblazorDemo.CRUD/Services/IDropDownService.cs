using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MudblazorDemo.CRUD.Services
{
    public interface IDropdownService
    {
        List<SelectListItem> ListofCountries();
        List<SelectListItem> ListofStates(int countryId);
        List<SelectListItem> ListofCities(int stateid);
    }
}
