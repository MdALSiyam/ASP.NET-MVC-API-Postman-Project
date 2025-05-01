namespace MasterDetailCRUDBearerTokenWEbAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MasterDetailCRUDBearerTokenWEbAPI.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MasterDetailCRUDBearerTokenWEbAPI.Models.AppDbContext context)
        {
            //context.Products.AddOrUpdate(p => p.ProductId,
            //     new Models.Product() { ProductId = 1, ProductName = "laptop" },
            //     new Models.Product() { ProductId = 2, ProductName = "Mobile" }
            //     );
            //context.Users.AddOrUpdate(u => u.UserId,
            //    new Models.User() { UserId = 1, UserName = "Siyam", Password = "12345", Email = "siyam@gmail.com", Roles = "Admin, User" },
            //    new Models.User() { UserId = 2, UserName = "Latif", Password = "12345", Email = "latif@gmail.com", Roles = "User" }
            //    );
        }
    }
}
