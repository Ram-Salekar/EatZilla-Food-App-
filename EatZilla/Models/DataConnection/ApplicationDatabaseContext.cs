 using EatZilla.Models.CoreClasses;
using Microsoft.EntityFrameworkCore;
namespace EatZilla.Models.DataConnection
{
    public class ApplicationDatabaseContext :DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext>options) :base(options) 
        {
            
        }
      public  DbSet<User> Users { get; set; }
      public    DbSet<Resturant> resturants { get; set; }
      public    DbSet<Dish> dishes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Resturant>().HasData(
                new Resturant { Rid = 101, Name = "Taksh", type = "Veg" },
                new Resturant { Rid = 102, Name = "Nadbrhma", type = "Snacks" },
                new Resturant { Rid = 103, Name = "Mataji", type = "Sweet" },
                new Resturant { Rid = 104, Name = "Ashirwad", type = "NonVeg" }
            );
        }


    }
}
