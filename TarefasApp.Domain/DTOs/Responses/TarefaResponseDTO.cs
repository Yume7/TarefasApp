using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Models;

namespace TarefasApp.Domain.DTOs.Responses
{
    public class TarefaResponseDTO
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }
     
        public StatusTarefa Status { get; set; }
    }

}
