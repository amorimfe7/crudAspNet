using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crudASPNET.Models;

public class Premium
{
    //data annotations P
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Insira o título do Premium")]
    [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve conter no mínimo 5 caracteres")]
    [DisplayName("Título")]
    public string Title { get; set; } = string.Empty;
    
    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }
    
    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno não encontrado")]
    public int StudentId { get; set; }
    
    public Student? Student { get; set; } //relacao
}