using GestionFilms.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionFilms.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Film> Films => Set<Film>();
}
