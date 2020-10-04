
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudentWebApi
{
     public class StudentRepo
     {
        public List<Student> BazaStudenti=new List<Student>();
        public string Inserare([FromBody]Student stud)
        {
        

        
            BazaStudenti.Add(stud);
            return "ok";
        
       
        }

     }
}