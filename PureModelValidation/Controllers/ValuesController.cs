using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PureModelValidation.Model;
using System;
using System.Collections.Generic;

namespace PureModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public IActionResult Post([FromBody]Customer customer)
        {
            var a = 404;
            var value = 10;
            var b = 0;
            var c = 10;
         
                switch (a)
                {
                    case 404:
                        NotFound();
                        return NotFound();
                case 401:
                        return Unauthorized();
                    case 500:
                        value = c / b;
                        return Ok(value);
                }

                return Ok(new Customer() { Email = "clivekumara@gmail", FirstName="sandun"});
          
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
