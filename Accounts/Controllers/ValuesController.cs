using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static Dictionary<String,String> keyValues = new Dictionary<String,String>();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return keyValues.Keys;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(String id)
        {
            return keyValues[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] KeyValuePair<String,String> pair)    
        {
            keyValues.Add(pair.Key, pair.Value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(String id, [FromBody] string value)
        {
            keyValues.Add(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            keyValues.Remove(id);
        }
    }
}
