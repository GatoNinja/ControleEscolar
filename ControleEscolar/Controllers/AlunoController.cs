using ControleEscolar.Contexts;
using ControleEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEscolar.Controllers;

[ApiController]
[Route("aluno")]
public class AlunoController : ControllerBase
{
    private AlunoContext AlunoContext { get; set; }

    public AlunoController(AlunoContext context)
    {
        AlunoContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(AlunoContext.Alunos);
    }


    [HttpGet("{id}")]
    public IActionResult GetAluno(int id)
    {
        var aluno = AlunoContext.Alunos.FirstOrDefault(a => a.Id == id);

        if (aluno is null)
        {
            return NotFound();
        }

        return Ok(aluno);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Aluno aluno)
    {
        AlunoContext.Alunos.Add(aluno);
        AlunoContext.SaveChanges();

        return Ok(aluno);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Aluno aluno)
    {
        var alunoAtual = AlunoContext.Alunos.FirstOrDefault(a => a.Id == id);

        if (alunoAtual is null)
        {
            return NotFound();
        }

        aluno.Id = id;

        AlunoContext.Entry(aluno).State = EntityState.Modified;

        return Ok(aluno);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var aluno = AlunoContext.Alunos.FirstOrDefault(a => a.Id == id);

        if (aluno is null)
        {
            return NotFound();
        }

        AlunoContext.Alunos.Remove(aluno);

        return Ok(true);
    }
}
