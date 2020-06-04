using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orquestador_Telecom.Services;

namespace Orquestador_Telecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return StatusServices.GetStatus();
        }
    }
}