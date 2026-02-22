using Microsoft.EntityFrameworkCore;
using Notes.Api.Models;

namespace Notes.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) {}

        public DbSet<Note> Notes => Set<Note>();
    }
}
