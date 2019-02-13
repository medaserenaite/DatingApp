using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers {
    // http://localhost:500/api/values
    //REST API uses http verbs to identify  the action it's going to return
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly DataContext _context;
        public ValuesController (DataContext context) 
        {
            _context = context;

        }
    [HttpGet]
    //task represents an asynchronous operation that can return a value
    public async Task<IActionResult> GetValues()
    {
        var values = await _context.Values.ToListAsync();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetValue(int id)
    {
        var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
        return Ok(value);
    }

        // GET api/values
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get () {
        //     // throw new Exception("Test Exception");
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/values/5
        // [HttpGet ("{id}")]
        // public ActionResult<string> Get (int id) {
        //     return "value";
        // }

        // POST api/values
        // [HttpPost]
        // public void Post ([FromBody] string value) { }

        // PUT api/values/5
        // [HttpPut ("{id}")]
        // public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
    //     [HttpDelete ("{id}")]
    //     public void Delete (int id) { }
    }
}