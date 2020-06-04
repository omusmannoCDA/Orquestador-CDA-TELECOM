using Microsoft.AspNetCore.Mvc;
using Orquestador_Telecom.Services;

namespace Orquestador_Telecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarClienteController : ControllerBase
    {
        //api/ConsultarCliente/id
        [HttpGet("{idSubscriber}")]
        public string Get(string id_subcriber) {

            return "";
        }

        [HttpGet("status")]
        public string GetStatus()
        {
            return ConsultarClienteServices.GetStatus();
        }
    }
}