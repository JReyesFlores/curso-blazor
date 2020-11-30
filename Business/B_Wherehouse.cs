using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Wherehouse
    {
        public static List<WherehouseEntity> ListWherehouse()
        {
            using (var db = new InventoryContext())
            {
                return db.Wherehouses.ToList();
            }
        }

        public static WherehouseEntity WherehouseById(string wherehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Wherehouses.Where(x=> x.WherehouseId.Equals(wherehouseId)).FirstOrDefault();
            }
        }

        public static void CreateWherehouse(WherehouseEntity wherehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Wherehouses.Add(wherehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWherehouse(WherehouseEntity wherehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Wherehouses.Update(wherehouse);
                db.SaveChanges();
            }
        }
    }
}
