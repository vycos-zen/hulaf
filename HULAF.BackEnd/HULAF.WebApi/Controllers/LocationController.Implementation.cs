using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers
{
    public class LocationController : LocationControllerBase
    {
        public override Task<List<CountryDto>> GetCountryList()
        {
           return Task.FromResult(new List<CountryDto>(){
               new CountryDto{
                   Guid = Guid.NewGuid(),
                   Name = "Hungary"
               },
               new CountryDto{
                   Guid = Guid.NewGuid(),
                   Name = "Slovakia"
               },
           });
        }
    }
}