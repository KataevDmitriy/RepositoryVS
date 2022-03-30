using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1
{
    public class CreateDbContext: DbContext    
    {
        public CreateDbContext(DbContextOptions<CreateDbContext> options): base(options)
        { }
        public DbSet<WebApplication1.Models.NOKTemplateCreateDb> NOKTemplateCreateDbs { get; set; }
        //CreateDbContexts
    }
}
