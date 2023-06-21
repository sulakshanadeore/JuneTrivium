using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public static List<StudModel> studs = new List<StudModel>()
        {
            new StudModel{Rollno=1,Name="A",Age=4 },
            new StudModel{Rollno=2,Name="B",Age=4 },
            new StudModel{Rollno=3,Name="C",Age=5 },
            new StudModel{Rollno=4,Name="D",Age=6 },
            new StudModel{Rollno=5,Name="E",Age=4 },


        };
        
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudModel> AllStudentDetails()
        {
            return studs;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public StudModel StudentByRollno(int id)
        {
            StudModel stud=studs.Find(s => s.Rollno == id);
            return stud;
        }

        // POST api/<StudentController>
        [HttpPost]
        public void StudentData([FromBody] StudModel value)
        {
            studs.Add(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void StudentDataToEdit(int id, [FromBody] StudModel value)
        {
            StudModel stud = studs.Find(s => s.Rollno == id);
            stud.Name = value.Name;
            stud.Age=value.Age;

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void StudentData(int id)
        {
            StudModel stud = studs.Find(s => s.Rollno == id);
            studs.Remove(stud);
        }
    }
}
