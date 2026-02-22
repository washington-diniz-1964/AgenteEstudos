using System;
using System.Collections.Generic;
using System.Text;

namespace AgenteEstudos.Console.Models;

public sealed class AnaliseErroResponse
{
    public string CausaProvavel { get; set; } = "";
    public List<string> TabelasEnvolvidas { get; set; } = new();
    public string NivelCriticidade { get; set; } = ""; // Baixo | Medio | Alto | Critico
    public string SugestaoAcao { get; set; } = "";
}