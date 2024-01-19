using crudASPNET.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace crudAspNet.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //relacao app x db > cria tabela bd
    public DbSet<Student> Students { get; set; } = default!; 
    public DbSet<Premium> Premiums { get; set; } = default!;   
}
