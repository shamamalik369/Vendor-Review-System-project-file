using Microsoft.EntityFrameworkCore;

namespace Vendor_Review_System.Models
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {

        }
        public ProjectContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<UserMaster> UserMasters { get; set; }
       
        public DbSet<FoodieModel> FoodieModels { get; set; }
        public DbSet<venmol> Venmols { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"server=SHIVA-17\SQLEXPRESS;database=DBVRSS;Integrated Security=true");
        }
    }
}
