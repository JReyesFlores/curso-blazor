using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WherehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WherehouseAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }

        public WherehouseEntity() => WherehouseId = Guid.NewGuid().ToString();
    }
}
