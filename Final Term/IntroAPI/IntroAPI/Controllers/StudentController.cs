﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
       public List<string> GetStudents()
        {
            string[] names = new string[] { "Ricky","Mahadi","Tahmid","Fatima","Ishrat","Nazia"};
            return names.ToList();
        }

        public string Post() {
            return "Post Called";
        }
        public string Put() {
            return "Put Called";
        }
    }
}
