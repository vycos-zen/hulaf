using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HULAF.DataAccess.Context;
using HULAF.Domain.Person;
using Location;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HULAF.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HulafController : ControllerBase
    {
        [HttpGet]
        public Task<string> Get()
        {
            using (var db = new HULAFContext())
            {
                db.Add(new MissingPerson() { LastSeenLocation = new SeenLocation() { City = "Budapest" } });
                db.SaveChanges();

                var returnValue = db.MissingPerson.Where(x => x.LastSeenLocation != null).FirstOrDefault().LastSeenLocation.City;

                return Task.FromResult(returnValue);
            }
        }
    }
}