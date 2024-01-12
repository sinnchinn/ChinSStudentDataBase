using ChinSStudentDataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace ChinSStudentDataBase.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
}
