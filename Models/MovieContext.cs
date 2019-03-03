using Microsoft.EntityFrameworkCore;

namespace aspNetSample.Models{
  public class MovieContext : DbContext{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options){}

    public DbSet<aspNetSample.Models.Movie> Movie {get; set;}
  }
}
