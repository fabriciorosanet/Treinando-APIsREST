using Microsoft.AspNetCore.Mvc;
using Valorant_APIsREST.Models;

namespace Valorant_APIsREST.Controllers;

[ApiController]
[Route("[controller]")]
public class ValorantController : Controller
{
   private List<Agente> agentes = new List<Agente>();


    [HttpPost]
   public void AdicionaAgente([FromBody] Agente agente)
    {
        agentes.Add(agente);
        Console.WriteLine(agente.Nome);
        Console.WriteLine(agente.Classe);
        Console.WriteLine(agente.NumeroDoAgente);
        Console.WriteLine(agente.QtdDeHorasJogadas);
    }

}
