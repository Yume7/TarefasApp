using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TarefasApp.Domain.DTOs.Requests;
using TarefasApp.Domain.DTOs.Responses;
using System.Text.Json;

public class TarefaService
{
    private readonly HttpClient _httpClient;

    public TarefaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TarefaResponseDTO>> Consultar()
    {
        var response = await _httpClient.GetAsync("tarefas/consultar");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<TarefaResponseDTO>>(content, options) ?? new List<TarefaResponseDTO>();
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Erro {response.StatusCode}: {errorContent}");
            return new List<TarefaResponseDTO>();
        }
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
