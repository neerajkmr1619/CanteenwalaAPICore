using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private Services.Services _services;
        public ValuesController(Services.Services services)
        {
            _services=services;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Student> students = _services.Get();
            return Ok(students);
            // Ok(new Student{Name=students[0].Name});
        }

        // GET api/values/5
        [HttpGet("{id:int}")]//it has route template with constraint 
        [Produces("application/json")]//only return json
        public IActionResult Get(int id,string value)
        {
            return Ok(new UserDetails{ID=id,Name="value"+id});
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails details)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get",new {ID=details.ID},details);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("put");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
