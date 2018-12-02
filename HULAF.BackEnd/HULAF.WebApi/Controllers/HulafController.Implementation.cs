using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers.Location
{
    public class HulafController : IHulafController
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

        public Task<List<CountryDto>> GetCountryListAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<Response> GetMissingPerson(Guid personGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetMissingPersonAsync(Guid personGuid)
        {
            throw new NotImplementedException();
        }

        public override Task<List<Anonymous>> GetMissingPersonList()
        {
            // return Task.FromResult(new List<MissingPersonDto>{
            //     new MissingPersonDto{
            //         Characteristics = new CharateristicsDto{
            //             KnownNames = new List<string>{
            //                 "Géza",
            //                 "Józsi"
            //             }
            //         }
            //     },
            //     new MissingPersonDto{
            //         Characteristics = new CharateristicsDto{
            //             KnownNames = new List<string>{
            //                 "Villi",
            //                 "Pumukli"
            //             }
            //         }
            //     },
            // });
            throw new NotImplementedException();

        }

        public Task<List<Anonymous>> GetMissingPersonListAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<Response2> Seekerperson(Guid personGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Response2> SeekerpersonAsync(Guid personGuid)
        {
            throw new NotImplementedException();
        }
    }
}