using Microsoft.EntityFrameworkCore;
using WebAPI_Aula1.Models;

namespace WebAPI_Aula1.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
