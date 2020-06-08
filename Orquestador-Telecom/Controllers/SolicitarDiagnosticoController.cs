using Microsoft.AspNetCore.Mvc;
using Orquestador_Telecom.Services;

namespace Orquestador_Telecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitarDiagnosticoController : ControllerBase
    {
        //api/SolicitarDiagnostico/id
        [HttpGet("{id_subscriber}")]
        public string Get(string id_subscriber)
        {
            return SolicitarDiagnosticoServices.GetConsultaComercial(id_subscriber);
        }

        [HttpGet("status")]
        public string GetStatus()
        {
            return SolicitarDiagnosticoServices.GetStatus();
        }
    }
}