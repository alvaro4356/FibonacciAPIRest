using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciAPi.Controllers
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
        public ActionResult<int> Get(int id)
        {
            
            int a, b, c;
            a = 0;
            b = 1;
            c = 0;

            if (id == 0)
            {
                int i = 0;
                return i;
            }
            else if (id == 1)
            {
                int j = 1;
                return j;
            }

            for (int k = 2; k <= id; k++)

            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
