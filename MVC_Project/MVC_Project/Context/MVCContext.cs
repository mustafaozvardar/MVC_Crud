using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Context
{
    public class MVCContext: DbContext
    {
        public MVCContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
