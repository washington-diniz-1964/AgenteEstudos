using System.Text.Json;
using AgenteEstudos.Console.Models;

var resp = new AnaliseErroResponse
{
    CausaProvavel = "Exemplo: chave estrangeira ausente",
    TabelasEnvolvidas = new() { "eso_eventos_enviados", "eso_S5001" },
    NivelCriticidade = "Medio",
    SugestaoAcao = "Revisar relacionamento e dados de origem antes do envio."
};

var json = JsonSerializer.Serialize(resp, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json);