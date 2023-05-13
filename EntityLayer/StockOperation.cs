using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StockOperation
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public DateTime IslemTarihi { get; set; }

        public string IslemTuru { get; set; }

        // İlişkiler

        public Company Company { get; set; }
        public ICollection<StockOperationDetails> StockOperationDetails { get; set; }

    }
}
