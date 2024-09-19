using Microsoft.EntityFrameworkCore;
using PortfolioMaker.Models;

namespace PortfolioMaker.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContext)
    :base(dbContext)
    {
        
    }
    
    DbSet<Project> Projects { get; set; }
    DbSet<ProjectInfo> ProjectInfos { get; set; }
}