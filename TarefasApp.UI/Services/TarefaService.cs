using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TarefasApp.Domain.DTOs.Requests;
using TarefasApp.Domain.DTOs.Responses;

public class TarefaService
{
    private readonly HttpClient _httpClient;

    public TarefaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TarefaResponseDTO>> Consultar()
    {
        return await _httpClient.GetFromJsonAsync<List<TarefaResponseDTO>>("tarefas/consultar");
    }

    public async Task<TarefaResponseDTO> ObterPorId(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<TarefaResponseDTO>($"tarefas/{id}");
    }

    public async Task Cadastrar(TarefaRequestDTO request)
    {
        await _httpClient.PostAsJsonAsync("tarefas/cadastrar", request);
    }

    public async Task Atualizar(Guid id, TarefaRequestDTO request)
    {
        await _httpClient.PutAsJsonAsync($"tarefas/atualizar/{id}", request);
    }

    public async Task Deletar(Guid id)
    {
        await _httpClient.DeleteAsync($"tarefas/deletar/{id}");
    }

}
