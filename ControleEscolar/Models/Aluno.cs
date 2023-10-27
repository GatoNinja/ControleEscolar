using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEscolar.Models;

[Table("alunos")]
public class Aluno
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Column("idade")]
    public int Idade { get; set; }

    [Column("primeiro_semestre")]
    public float NotaPrimeiroSemestre { get; set; }

    [Column("segundo_semestre")]
    public float NotaSegundoSemestre { get; set; }

    [Column("professor")]
    public string Professor { get; set; } = string.Empty;

    [Column("sala")]
    public int Sala { get; set; }
}
