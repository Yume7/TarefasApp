using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TarefasApp.Domain.DTOs;
using TarefasApp.Domain.DTOs.Requests;
using TarefasApp.Domain.Services;

namespace TarefasApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly TarefaService _tarefaService;

        public TarefasController(TarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] TarefaRequestDTO request)
        {
            try
            {
                _tarefaService.Cadastrar(request);
                return Ok(_tarefaService.Consultar());
            }
            catch (ApplicationException ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }

        [HttpGet("consultar")]
        public IActionResult Consultar()
        {
            return Ok(_tarefaService.Consultar());
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)

        {
            try
            {

                var tarefa = _tarefaService.ObterPorId(id);
                if (tarefa == null)
                    return NotFound();

                return Ok(tarefa);

            }
            catch (ApplicationException ex)
            {
                return NotFound(new { erro = ex.Message });
            }
        }

        [HttpPut("atualizar/{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] TarefaRequestDTO request)
        {
            try
            {
                _tarefaService.Atualizar(id, request);
                return Ok(_tarefaService.Consultar());
            }
            catch (ApplicationException ex)
            {
                return NotFound(new { erro = ex.Message });
            }
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _tarefaService.Deletar(id);
                return Ok(_tarefaService.Consultar());
            }
            catch (ApplicationException ex)
            {
                return NotFound(new { erro = ex.Message });
            }
        }
    }
}
