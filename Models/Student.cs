using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crudASPNET.Models;

public class Student
{
    //data annotations S
    
    [Key] //indica id=pk
    [DisplayName("Id")] //nome exibido tela
    public int Id { get; set; }
    
    //validacoes name
    [Required(ErrorMessage = "Insira o nome")] //informa campo obrigatório; 
    [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;
    
    //validacoes email
    [Required(ErrorMessage = "Insira o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")] //verifica email valido or not
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
}