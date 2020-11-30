using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity CategoryById(string CategoryId)
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.Where(x => x.CategoryId.Equals(CategoryId)).FirstOrDefault();
            }
        }

        public static void CreateCategory(CategoryEntity category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(category);
                db.SaveChanges();
            }
        }
    }
}
