using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        static readonly List<string> str = new List<string> { "India", "America", "England" };
        
        [HttpGet(Name="GetValuesData")]
        public List<string> Get()
        {
            return str;
        }

        [HttpPost(Name = "PostValuesData")]
        public string Post([FromBody] string s)
        {
            str.Add(s);
            return s;
        }


        [HttpPut(Name = "PutValuesData")]
        public string Put( [FromBody] string oldstring,string toreplace)
        {
            int found = str.FindIndex(0,s1 => s1 == oldstring);
            str.Insert(found, toreplace);

            return toreplace;

        }

        [HttpDelete(Name = "DeleteValuesData")]

        public string Delete([FromBody]string s)
        {
            string deleted = str.Find(s1 => s1 == s);
            str.Remove(deleted);
            return deleted;

        }




    }
}
