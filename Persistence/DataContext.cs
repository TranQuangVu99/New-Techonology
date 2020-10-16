using System;
using Domain;
using Microsoft.EntityFrameworkCore ;
namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values {get ; set ;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value { Id = 1, Name = "Giá trị này là nhập cho vui"},
                new Value { Id = 2, Name = "Giá trị này là nhập chơi"},
                new Value { Id = 3, Name = "Giá trị này là giá trị thừa"}
            );
        }
    }
}
