using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WherehouseEntity> Wherehouses { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Si no se encuentra configurado
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;database=dbInventory;user id=sa;password=sql;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Aseo Hogar" },
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Aseo" },
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Hogar" },
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Perfumeria" },
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Salud" },
                new CategoryEntity() { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Videojuegos" }
                );

            modelBuilder.Entity<WherehouseEntity>().HasData(
                new WherehouseEntity() { WherehouseId = Guid.NewGuid().ToString(), WherehouseName = "Bodega central", WherehouseAddress = "Calle 123" },
                new WherehouseEntity() { WherehouseId = Guid.NewGuid().ToString(), WherehouseName = "Bodega Sur", WherehouseAddress = "Calle 562" },
                new WherehouseEntity() { WherehouseId = Guid.NewGuid().ToString(), WherehouseName = "Bodega Norte", WherehouseAddress = "Calle 987" }
                );
        }
    }
}
