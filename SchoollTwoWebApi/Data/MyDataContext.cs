using Microsoft.EntityFrameworkCore;
using SchoollTwoWebApi.Entities;

namespace SchoollTwoWebApi.Data
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
