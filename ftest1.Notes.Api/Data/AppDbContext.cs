using Microsoft.EntityFrameworkCore;
using ftest1.Notes.Api.Models;
using ftest1.Notes.Api.Models.Users;


namespace ftest1.Notes.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) {}

        public DbSet<Note> Notes => Set<Note>();
        public DbSet<User> Users { get; set; }
    }
}