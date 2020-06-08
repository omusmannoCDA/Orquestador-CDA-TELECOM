using DiagnosticoTecnicoBasico.Common;
using Orquestador_Telecom.Domain.Constants;
using System;
using System.Net;

namespace Orquestador_Telecom.Services
{
    public static class SolicitarDiagnosticoServices
    {
        public static string GetConsultaComercial(string idSubscriber) {            
            try
            {
                string url = Constants.urlInformacionComercial + idSubscriber;
                var jsonResponse = Utilities.GetResponse(url);

                return jsonResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex);
            }

        }

        public static string GetStatus()
        {
            try
            {
                GetConsultaComercial("22");
                return HttpStatusCode.OK + "OK";
            }
            catch (Exception ex)
            {
                return "Error - Solicitar Diagnostico - " + ex.Message.Split('.')[3];
            }


        }
    }
}
