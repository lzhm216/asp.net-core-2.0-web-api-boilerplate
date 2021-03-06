﻿using System.Linq;
using CoreApi.Web.Controllers.Bases;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// ReSharper disable All

namespace CoreApi.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : BaseController<ValuesController>
    {
        public ValuesController(ICoreService<ValuesController> coreService):
            base(coreService)
        {
            Logger.LogCritical("Hi, Im Dave!!!!!!!!!!!!!!!!! {User}", "Dave");
            //LogCritical("xxx {User}", "Nick");
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
