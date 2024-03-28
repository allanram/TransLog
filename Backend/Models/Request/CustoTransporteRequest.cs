using System.ComponentModel.DataAnnotations;

namespace Backend.Models.Request
{
    public class CustoTransporteRequest
    {
        public double Distancia { get; set; }
       
        public double Peso { get; set; }

        public double largura { get; set; }
        
        public double Altura { get; set; }
      
       
    }
}
