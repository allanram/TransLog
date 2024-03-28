using System.ComponentModel.DataAnnotations;

namespace Frontend.Model.Request
{
    public class CargaTranspote
    {


        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 10,
            ErrorMessage = "Nome deve ter no minímo 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime Nascimento { get; set; }
        public string Distancia { get; set; }
        [Required(ErrorMessage = "Insira uma distancia")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Insira um Peso")]
        public string largura { get; set; }
        [Required(ErrorMessage = "Insira uma largura")]
        public string Altura { get; set; }
        [Required(ErrorMessage = "Insira uma Altura")]

        
        public string Comprimento { get; set; }
       
    }
}
