using System;
using System.Collections.Generic;
using System.Linq;
using TarefasApp.Domain.DTOs;
using TarefasApp.Domain.DTOs.Requests;
using TarefasApp.Domain.DTOs.Responses;
using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Models;

namespace TarefasApp.Domain.Services
{
    public class TarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public void Cadastrar(TarefaRequestDTO request)
        {
            var tarefa = new Tarefa
            {
                Id = Guid.NewGuid(),
                Titulo = request.Titulo,
                Descricao = request.Descricao,
                Data = request.Data,
                Status = request.Status
            };

            _tarefaRepository.Cadastrar(tarefa);
        }

        public List<TarefaResponseDTO> Consultar()
        {
            return _tarefaRepository.Consultar()
                .Select(t => new TarefaResponseDTO
                {
                    Id = t.Id,
                    Titulo = t.Titulo,
                    Descricao = t.Descricao,
                    Data = t.Data,
                    Status = t.Status
                })
                .ToList();
        }

        public void Atualizar(Guid id, TarefaRequestDTO request)
        {
            var tarefa = _tarefaRepository.ObterPorId(id);
            if (tarefa == null)
                throw new ApplicationException("Tarefa não encontrada.");

            tarefa.Titulo = request.Titulo;
            tarefa.Descricao = request.Descricao;
            tarefa.Data = request.Data;
          
            tarefa.Status = request.Status;

            _tarefaRepository.Atualizar(tarefa);
        }

        public void Deletar(Guid id)
        {
            var tarefa = _tarefaRepository.ObterPorId(id);
            if (tarefa == null)
                throw new ApplicationException("Tarefa não encontrada.");

            _tarefaRepository.Deletar(tarefa);
        }

        public TarefaResponseDTO ObterPorId(Guid id)
        {
            var tarefa = _tarefaRepository.ObterPorId(id);
            if (tarefa == null)
                throw new ApplicationException("Tarefa não encontrada.");

            return new TarefaResponseDTO
            {
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                Data = tarefa.Data,
            
                Status = tarefa.Status
            };
        }

    }
}
