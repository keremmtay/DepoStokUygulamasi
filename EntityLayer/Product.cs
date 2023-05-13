using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string UrunAdi { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(13)]
        public string BarkodKodu { get; set; }
        [Required]
        public int StokMiktari { get; set; }
        public double BirimFiyat { get; set; }
        [Required]
        public int UnitId { get; set; }
        [StringLength(5)]
        public string RafNo { get; set; }
        [Required]
        public int WarehouseId { get; set; }
        public int MinStok { get; set; }
        public int MaxStok { get; set; }
        
        // ilişkiler

        public Category Category { get; set; }
        public Unit Unit { get; set; }
        public Warehouse Warehouse { get; set; }
        public ICollection<StockOperationDetails> StockOperationDetails { get; set; }

    }
}
