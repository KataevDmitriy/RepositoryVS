using Microsoft.EntityFrameworkCore;

namespace EFWebApi.Models
{
    public class EFWebApiContext : DbContext
    {
        public EFWebApiContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<NOK> NOKs { get; set; }
    }
}
