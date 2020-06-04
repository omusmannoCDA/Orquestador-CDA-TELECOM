using System.Net;

namespace Orquestador_Telecom.Services
{
    public static class StatusServices
    {
        public static string GetStatus() {
            string response = SolicitarDiagnosticoServices.GetStatus() + "\n";
            response += GenerarDiagnosticoServices.GetStatus() + "\n";
            response += ConsultarClienteServices.GetStatus() + "\n";
            response += RecuperarDiagnosticoServices.GetStatus() + "\n";
            response += WorkflowAsistidosServices.GetStatus() + "\n";
            return response;
        }
    }
}
