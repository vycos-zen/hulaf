using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers.Person
{
    public class PersonController : PersonControllerBase
    {
        public override Task<MissingPersonDto> GetMissingPerson(Guid personGuid)
        {
            throw new NotImplementedException();
        }

        public override Task<List<MissingPersonDto>> GetMissingPersonList()
        {
            return Task.FromResult(new List<MissingPersonDto>{
                new MissingPersonDto{
                    Characteristics = new CharateristicsDto{
                        KnownNames = new List<string>{
                            "Géza",
                            "Józsi"
                        }
                    }
                },
                new MissingPersonDto{
                    Characteristics = new CharateristicsDto{
                        KnownNames = new List<string>{
                            "Villi",
                            "Pumukli"
                        }
                    }
                },                
            });
        }

        public override Task<SeekerPersonDto> Seekerperson(Guid personGuid)
        {
            throw new NotImplementedException();
        }
    }
}