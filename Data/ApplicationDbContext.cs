using System;
using Microsoft.EntityFrameworkCore;
using SecureWeb.Models;

namespace SecureWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Students> Students { get; set; } = null!;
    public DbSet<User> User { get; set; } = null!;
}