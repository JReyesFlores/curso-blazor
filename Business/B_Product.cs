using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.Where(x => x.ProductId.Equals(id)).FirstOrDefault();
            }
        }

        public static void CreateProduct(ProductEntity product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(product);
                db.SaveChanges();
            }
        }
    }
}
