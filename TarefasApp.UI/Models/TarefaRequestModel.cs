using System.ComponentModel.DataAnnotations;
namespace TarefasApp.UI.Models
{
    public class TarefaRequestModel
    {
        [Required(ErrorMessage = "Por favor, informe o título.")]
        [MaxLength(100, ErrorMessage = "O título deve ter no máximo {1} caracteres.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe a descrição.")]
        [MaxLength(300, ErrorMessage = "A descrição deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe a data.")]
        public DateTime Data { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Por favor, informe o status.")]
        public string Status { get; set; }
    }
}
