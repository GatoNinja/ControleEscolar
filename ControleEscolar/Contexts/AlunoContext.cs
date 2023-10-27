using ControleEscolar.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEscolar.Contexts;

public class AlunoContext : DbContext
{
    public AlunoContext(DbContextOptions<AlunoContext> options): base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; } = default!;
}
