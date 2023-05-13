using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string KategoriAdi { get; set; }
        [Required]
        [StringLength(200)]
        public string Aciklama { get; set; }

        // İlişkiler

        public ICollection<Product> Products { get; set; }

    }
}
