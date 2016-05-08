using System.Data.Entity;

namespace Products.DAL.Model
{
    public class ProductDbInitializer: DropCreateDatabaseAlways<ProductDbContext>
    {
        protected override void Seed(ProductDbContext db)
        {
            db.Products.Add(new Product { Name = "Штаны", Quantity = 47, Price = 27, Category = "Товар" });
            db.Products.Add(new Product { Name = "Футболка", Quantity = 50, Price = 150, Category = "Товар" });
            db.Products.Add(new Product { Name = "Шорты", Quantity = 35, Price = 95, Category = "Товар" });
            db.Products.Add(new Product { Name = "Концерт", Quantity = 1, Price = 2700, Category = "Услуга" });
            db.Products.Add(new Product { Name = "Уборка", Quantity = 4, Price = 270, Category = "Услуга" });
            db.Products.Add(new Product { Name = "Ремонт", Quantity = 8, Price = 700, Category = "Услуга" });

            base.Seed(db);
        }
    }
}
