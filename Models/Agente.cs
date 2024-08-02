using System.ComponentModel.DataAnnotations;

namespace Valorant_APIsREST.Models
{
    public class Agente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do agente é obrigatório")]
        [StringLength(20, ErrorMessage = "Você excedeu o número de caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A classe do agente é obrigatória")]
        [StringLength(15, ErrorMessage = "Você excedeu o número de caracteres")]
        public string Classe { get; set; }
        
        [Required(ErrorMessage = "O número do agente é obrigatório")]
        [Range(0, 10, ErrorMessage = "Número do agente invalido")]
        public int NumeroDoAgente { get; set; }
       
        [Required(ErrorMessage = "A quantidade de horas jogadas é obrigatória")]
        public double QtdDeHorasJogadas { get; set; }

    }
}
