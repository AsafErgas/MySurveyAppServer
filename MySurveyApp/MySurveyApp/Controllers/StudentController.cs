﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySurveyApp.Models;

namespace MySurveyApp.Controllers
{

    public class StudentController : ApiController
    {



        [HttpGet]
        [Route("api/studentcount")]
        public int Get()
        {
            Student s = new Student();
            int M = s.Numofstudent();
            return M;
        }

        [HttpPost]
        [Route("api/addstudentfromfile")]
        public void Post([FromBody]Student s)
        {
            s.insertstudent();

        }
        [HttpPost]
        [Route("api/addstudent")]
        public void Post2([FromBody]Student s)
        {
            s.insertstudent();

        }
        [HttpGet]
        [Route("api/allstudent")]
        public IEnumerable<Student> Get2()
        {
            Student s = new Student();
            List<Student> M = s.ReadStudent();
            return M;
        }
        [HttpPut]
        [Route("api/editstudent")]
        public void Put([FromBody]Student s, string su)
        {
            s.EditPass(su);

        }

        [HttpPut]
        [Route("api/deletestudent")]
        public void Put2([FromBody]Student s, string un)
        {
            s.deletestudent(un);

        }

        [HttpGet]
        [Route("api/student")]
        public IEnumerable<Student> Get3(string Username, string Password)
        {
            Student s2 = new Student();
            List<Student> LL = s2.Login(Username, Password);
            return LL;
        }

        [HttpGet]
        [Route("api/getpushstud")]
        public IEnumerable<Student> Get4(string un)
        {
            Student s2 = new Student();
            List<Student> LL = s2.getstudforpush(un);
            return LL;
        }
        [HttpPost]
        [Route("api/edittoken")]
        public void Put(string Token, string username)
        {
            Student s = new Student();
            s.Edittoken(Token, username);

        }

    }
}