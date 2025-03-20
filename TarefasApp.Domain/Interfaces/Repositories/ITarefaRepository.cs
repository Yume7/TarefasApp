using System;
using System.Collections.Generic;
using TarefasApp.Domain.Models;

namespace TarefasApp.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        void Cadastrar(Tarefa tarefa);
        void Atualizar(Tarefa tarefa);
        void Deletar(Tarefa tarefa);
        Tarefa? ObterPorId(Guid id);

        List<Tarefa> Consultar();
        
    }
}
