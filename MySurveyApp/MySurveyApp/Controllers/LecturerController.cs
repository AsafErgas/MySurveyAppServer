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

    public class LecturerController : ApiController
    {



     
        [HttpGet]
        [Route("api/Lecturerserver")]
        public IEnumerable<Lecturer> Get2(string UserName, string Password)
        {
            Lecturer s2 = new Lecturer();
            List<Lecturer> LL = s2.Loginserver(UserName, Password);
            return LL;
        }
    }
}