using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Domain.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public DateTime Data { get; set; }
       


    }
}
