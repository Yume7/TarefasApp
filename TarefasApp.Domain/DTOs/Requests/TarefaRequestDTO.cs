using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Models;

namespace TarefasApp.Domain.DTOs.Requests
{
    public class TarefaRequestDTO
    {
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o título da tarefa.")]
        public string? Titulo { get; set; }

        [MaxLength(300, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição da tarefa.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da tarefa.")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1753-01-01", "9999-12-31", ErrorMessage = "Por favor, informe uma data válida.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe o status da tarefa.")]
        public StatusTarefa Status { get; set; }
    }
}
