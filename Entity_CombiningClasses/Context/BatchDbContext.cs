using Entity_CombiningClasses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity_CombiningClasses.Context
{
    public class BatchDbContext : DbContext
    {
        public BatchDbContext()
        {

        }
        public BatchDbContext(DbContextOptions<BatchDbContext> dbContextOptions) : 
            base(dbContextOptions)
        {

        }
        public DbSet<Training> training { get; set; }

        public DbSet<Entity_CombiningClasses.Models.Course> Course { get; set; }
       
    }
}
