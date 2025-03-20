using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Models;
using TarefasApp.Infra.Data.Contexts;

namespace TarefasApp.Infra.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly DataContext _context;

        public TarefaRepository(DataContext context)
        {
            _context = context;
        }

        public void Cadastrar(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
        }

        public List<Tarefa> Consultar()
        {
            return _context.Set<Tarefa>().AsNoTracking().ToList();
        }

        public Tarefa? ObterPorId(Guid id)
        {
            return _context.Set<Tarefa>().Find(id);
        }

        public void Atualizar(Tarefa tarefa)
        {
            _context.Update(tarefa);
            _context.SaveChanges();
        }

        public void Deletar(Tarefa tarefa)
        {
            _context.Remove(tarefa);
            _context.SaveChanges();
        }
    }
}
