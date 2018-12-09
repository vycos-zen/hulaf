using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HULAF.WebApi.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<string> Values { get; set; }
        // GET api/values
        [HttpGet, Route("values")]
        public async Task<ActionResult<List<string>>> GetValues()
        {
            await Task.Delay(0);
            return this.Values;
        }

        // GET api/values/5
        [HttpGet, Route("values/get")]
        public async Task<ActionResult<string>> GetValueById([FromBody] int id)
        {
            await Task.Delay(0);

            if (id > Values.Count)
            {
                ModelState.AddModelError("wrongNumber", "Entered a wrong value");
                return BadRequest();
            }
            return Values[id];
        }

        // POST api/values
        [HttpPost, Route("values/createvalues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> PostValue([FromBody] string value)
        {
            this.Values.Add("value" + this.Values.Count.ToString());
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("values/put")]
        public async Task<ActionResult> PutValue(int id, [FromBody] string value)
        {
            return Ok();

        }

        // DELETE api/values/5
        [HttpDelete("values/delete/{id}")]
        public async Task<ActionResult> DeleteValue(int id)
        {
            return Ok();
        }

        public ValuesController()
        {
            this.Values = new List<string>
            {

            };
        }
    }
}
