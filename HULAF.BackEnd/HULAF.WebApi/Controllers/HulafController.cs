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

    [Route("[controller]")]
    [ApiController]
    public class HulafController : ControllerBase
    {
        private readonly HULAFContext context;


        [HttpGet]
        public Task<List<MissingPerson>> Get()
        {
            using (context)
            {
                context.Add(new MissingPerson() { LastSeenLocation = new SeenLocation() { City = "Budapest" } });
                context.SaveChanges();

                var returnValue = context.MissingPerson.ToList();

                return Task.FromResult(returnValue);
            }
        }

    public HulafController(HULAFContext context)
    {
     this.context = context;   
    }
    }
}