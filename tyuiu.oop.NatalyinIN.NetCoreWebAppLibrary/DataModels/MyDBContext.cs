using Microsoft.EntityFrameworkCore;
namespace tyuiu.oop.NatalyinIN.NetCoreWebAppLibrary.DataModels
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }
}
