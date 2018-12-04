using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers
{
    public class HulafController : HulafControllerBase
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

        public override Task<MissingPersonDto> GetMissingPerson(Guid personGuid)
        {
            throw new NotImplementedException();
        }

        public override Task<List<MissingPersonDto>> GetMissingPersonList()
        {
            return Task.FromResult(new List<MissingPersonDto>{
            new MissingPersonDto{
                Characteristics = new CharacteristicsDto{
                    KnownNames = new List<string>{
                        "Géza",
                        "Józsi"
                    }
                }
            },
            new MissingPersonDto{
                Characteristics = new CharacteristicsDto{
                    KnownNames = new List<string>{
                        "Villi",
                        "Pumukli"
                    }
                }
            },
        });
        }

        public override Task<SeekerPersonDto> GetSeekerPerson(Guid personGuid)
        {
            throw new NotImplementedException();
        }
    }
}