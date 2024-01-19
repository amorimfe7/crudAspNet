using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crudASPNET.Models;

public class Student
{
   
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Insira o nome")] 
    [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Insira o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
}