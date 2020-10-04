using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using  Newtonsoft.Json;

namespace StudentWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        StudentRepo Students=new StudentRepo();
         
        //List<Student> Students=new List<Student>()
       // {
        //    new Student(){Id=1,Nume="dsfsdf",Facultate="dfsf",An=4}
       // }; 
       
        
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return Students.BazaStudenti;
        }
       [HttpPost]
       public string Insert([FromBody]string s)
       {
           Student stud=JsonConvert.DeserializeObject<Student>(s);
           //return Students.Inserare(stud);
           return s;
       }
    }
}
