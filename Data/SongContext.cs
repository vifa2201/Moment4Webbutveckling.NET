using Microsoft.EntityFrameworkCore;
using Moment4.Models;

namespace Moment4.Data;

public class SongContext : DbContext 
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<SongModel> Songs { get; set; }
    public DbSet<ArtistModel> Artists { get; set; }

    public DbSet<CategoryModel> Categories { get; set; }
}