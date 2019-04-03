﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySurveyApp.Models;

namespace MySurveyApp.Controllers
{
    public class LabController : ApiController
    {
        [HttpPost]
        [Route("api/lab")]
        public void Post([FromBody]Lab l)
        {
            l.insertlab();

        }

        [HttpGet]
        [Route("api/showlab")]
        public IEnumerable<Lab> Get(string lecId)
        {
            Lab s = new Lab();
            List<Lab> L = s.ReadLabs(lecId);
            return L;
        }

        [HttpGet]
        [Route("api/allLabs")]
        public IEnumerable<Lab> Get()
        {
            Lab s = new Lab();
            List<Lab> L = s.ReadAllLabs();
            return L;
        }

    }
}