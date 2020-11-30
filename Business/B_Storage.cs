using DataAccess;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> ListStorages()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity storage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(storage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWherehouse(string storageId)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.Where(x => x.StorageId.Equals(storageId)).Any();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string warehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Wherehouse)
                    .Where(x => x.WherehouseId.Equals(warehouseId)).ToList();
            }
        }

        public static void UpdateStorage(StorageEntity storage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(storage);
                db.SaveChanges();
            }
        }
    }
}
