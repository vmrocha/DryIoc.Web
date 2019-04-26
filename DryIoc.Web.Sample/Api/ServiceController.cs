using DryIoc.Web.Sample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DryIoc.Web.Sample.Api
{
    public class ServiceController : ApiController
    {
        private readonly ITestService _testService;

        public ServiceController(ITestService testService)
        {
            _testService = testService;
        }

        public IHttpActionResult Get()
        {
            return Ok(_testService.CurrentTime.ToString());
        }
    }
}
