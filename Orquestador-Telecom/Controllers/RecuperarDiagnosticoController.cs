using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orquestador_Telecom.Services;

namespace Orquestador_Telecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecuperarDiagnosticoController : ControllerBase
    {
        [HttpGet("status")]
        public string GetStatus()
        {
            return RecuperarDiagnosticoServices.GetStatus();
        }
    }
}