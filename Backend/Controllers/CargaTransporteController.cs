using Backend.Models.Request;
using Backend.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargaTransporteController : ControllerBase
    {

        public const double valorFixoKm = 0.5;
        public const double adicionalKg = 1;
        public const double valorAdicionalM = 2;


        [HttpGet]
        [Route("calcular")]

       
        public IActionResult CalcularCusto([FromQuery] CustoTransporteRequest request)
        {

            var custoFrete = (request.Distancia * valorFixoKm) + (request.Peso * adicionalKg) + (request.largura * request.Altura * valorAdicionalM);

            var response = new CustoTransporteResponse();
            response.ValorDotransporte = custoFrete;

            return Ok(response);
        }
        
    }
}
