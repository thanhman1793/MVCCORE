using App.Models.Contacts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC.Model
{
    //MVC.Model.AppDbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Phương thức khởi tạo này chứa options để kết nối đến MS SQL Server
            // Thực hiện điều này khi Inject trong dịch vụ hệ thống
        }

        protected override void OnConfiguring(DbContextOptionsBuilder buider){
            base.OnConfiguring(buider);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            // foreach(var entityType in modelBuilder.Model.GetEntityTypes()){
            //     var tableName = entityType.GetTableName();
            //     if(tableName.StartsWith("AspNet")){
            //         entityType.SetTableName(tableName.Substring(6));
            //     }
            // }
        }

        public DbSet<Contact> Contacts {get;set;}
    }
}