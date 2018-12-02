using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers.Location
{
    public class LocationController : LocationControllerBase
    {
        public override Task<List<CountryDto>> GetCountryList()
        {
            return Task.FromResult(new List<CountryDto>(){
               new CountryDto{
                   Guid = Guid.NewGuid(),
                   Name = "Hungary",
                   DialingCode = 36,
               },
               new CountryDto{
                   Guid = Guid.NewGuid(),
                   Name = "Slovakia",
                   DialingCode = 421,

               },
           });
        }
    }
}