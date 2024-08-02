using Microsoft.AspNetCore.Mvc;
using Valorant_APIsREST.Models;

namespace Valorant_APIsREST.Controllers;

[ApiController]
[Route("[controller]")]
public class ValorantController : Controller
{
    private static List<Agente> agentes = new List<Agente>();
    private static int id = 0;


    [HttpPost]
    public void AdicionaAgente([FromBody] Agente agente)
    {
        agente.Id = id++;
        agentes.Add(agente);
        Console.WriteLine(agente.Nome);
        Console.WriteLine(agente.Classe);
        Console.WriteLine(agente.NumeroDoAgente);
        Console.WriteLine(agente.QtdDeHorasJogadas);
    }

    [HttpGet]
    public IEnumerable<Agente> RecuperaAgentes()
    {
        return agentes;
    }

    [HttpGet("{id}")]
    public Agente? RecuperaAgentesPorId(int id)
    {
       return agentes.FirstOrDefault(agente => agente.Id == id);
    }

}
