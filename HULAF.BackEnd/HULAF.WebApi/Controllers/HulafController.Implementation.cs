//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace HULAF.WebApi.Controllers
//{
//    [ApiController]
//    public class HulafController : HulafControllerBase
//    {
//        public override async Task<ActionResult<List<CountryDto>>> GetCountryList()
//        {
//            return new List<CountryDto>(){
//               new CountryDto{
//                   Guid = Guid.NewGuid(),
//                   Name = "Hungary",
//                   DialingCode = 36,
//               },
//               new CountryDto{
//                   Guid = Guid.NewGuid(),
//                   Name = "Slovakia",
//                   DialingCode = 421,

//               },
//           };
//        }

//        //[HttpGet("person/missingpersonx/{id}")]
//        public override async Task<ActionResult<MissingPersonDto>> GetMissingPerson([FromBody] Guid id)
//        {
//            await new Task(() => {

//            });
//            if(id == null)
//            {
//                return NotFound();
//            }
//            return new MissingPersonDto { Guid = Guid.NewGuid() };
//        }


//        public override Task<List<MissingPersonDto>> GetMissingPersonList()
//        {
//            return Task.FromResult(new List<MissingPersonDto>{
//            new MissingPersonDto{
//                Characteristics = new CharacteristicsDto{
//                    KnownNames = new List<string>{
//                        "Géza",
//                        "Józsi"
//                    }
//                }
//            },
//            new MissingPersonDto{
//                Characteristics = new CharacteristicsDto{
//                    KnownNames = new List<string>{
//                        "Villi",
//                        "Pumukli"
//                    }
//                }
//            },
//        });
//        }

//        public override Task<SeekerPersonDto> GetSeekerPerson(Guid personGuid)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}